using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Globalization;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.IO;
using farhaniPersianDate;
public partial class UC_Mang_News_AddNews : System.Web.UI.UserControl
{
    NewsManager news = new NewsManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        lblMessage.ForeColor = Color.Red;
        imSuccess.Visible = false;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        if (ValidationSummary1.Page.IsValid)
        {
           
            news.NewsName = title.Text;
            string temp = FTBText.Text.Replace("\"", "'");
            news.Context = temp;
            if(olaviat.Text!="")
            news.Priority = int.Parse(olaviat.Text.ToString());
            inputdate();
            news.Reshte = int.Parse(reshteddl.SelectedValue);
            string extension = Path.GetExtension(FileUpload1.FileName).ToString();
            news.imageName = "~/images/News/" + FileUpload1.FileName;
            if (FileUpload1.PostedFile.ContentLength > 0 && (extension == ".jpg" || extension == ".gif" || extension == ".JPEG" || extension == ".GIF" || extension == ".JPG"))
                {
                    int result = news.newsContextWrite();
                    if (result == 1)
                    {
                        imSuccess.Visible = true;
                        imSuccess.ImageUrl = "../../../images/succes.gif";
                        lblMessage.ForeColor = Color.Blue;
                        FileUpload1.SaveAs(Server.MapPath("~/images/News/") + FileUpload1.FileName);
                        lblMessage.Text = "موضوع جدید با موفقیت به تعریف شد";
                        clean();
                    }
                    else if (result == -1)
                    {
                        imSuccess.Visible = true;
                        imSuccess.ImageUrl = "../../../images/error.gif";
                        lblMessage.Text = "موضوعی با این عنوان وجود دارد . لطفا عنوان دیگری را وارد کنید";
                    }
                    else
                    {
                        imSuccess.Visible = true;
                        imSuccess.ImageUrl = "../../../images/error.gif";
                        lblMessage.Text = "خطا در تعریف موضوع جدید.";
                    }
                }
                else
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "لطفا تصویری را برای خبرتان انتخاب نمائید" + "و یا تصویر وارده شما با یکی از فرمت های زیر باشد" + "<br/>" + "JPG   jpg   GIF  gif  JPEG ";

                }
            }
    }
    private void clean() 
    {
        title.Text = "";
        FTBText.Text = "";
        olaviat.Text = "";
        pdp.Text= "";
        pdp2.Text = "";
        
    }
    public void inputdate()
    {
        date d = new date();
        if (pdp.Text == "")
            news.activeDate=d.GetPersianDateString1(DateTime.Now);
        else
            news.activeDate = pdp.PersianDateString;
        if (pdp2.Text == "")
            news.expDate =d.GetPersianDateString1(DateTime.Now.AddMonths(1));
        else
            news.expDate = pdp2.PersianDateString;
    }
   

}
