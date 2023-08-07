using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class UC_Mang_News_updatenewsl : System.Web.UI.UserControl
{
    public int newsID=0;
    NewsManager news = new NewsManager();
    NewsManager news1 = new NewsManager();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request["page"] != null && Request["page"] == "updatenews"
            && Request["id"] != null)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);
                newsID = id;
            }
            catch
            {
                Response.Redirect("./manag.aspx");
            }
            fill();
              }

    }
    
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=newsmanag");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {
            news.NewsName = title.Text;
            string temp = FTBText.Text.Replace("\"", "'");
            news.NewsID = newsID;
            news.Context = temp;
            if (olaviat.Text != "")
            news.Priority = int.Parse(olaviat.Text.ToString());
            inputdate();
            int result = news.updatenews();
                if (result == 1)
                {
                    Response.Redirect("./manag.aspx?page=newsmanag");
                }
                else if (result == -1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "خبر با این عنوان وجود دارد . لطفا عنوان دیگری را وارد کنید";
                }
                else
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "خطا درویرایش خبر.";
                }
        }
       }
    public void fill()
    {
        NewsManager news2 = new NewsManager();
        news2.NewsID = newsID;
        news2.newsContextRead();
        title.Text = news2.NewsName;
        FTBText.Text = news2.Context;
    }
    public void inputdate()
    {
        news1.NewsID=newsID;
        news1.newsContextRead();
        if (pdp.Text == "")
            news.activeDate = news1.activeDate;
        else
            news.activeDate = pdp.PersianDateString;
        if (pdb1.Text == "")
             news.expDate= news1.expDate;
        else
            news.expDate = pdb1.PersianDateString;
    }
}
