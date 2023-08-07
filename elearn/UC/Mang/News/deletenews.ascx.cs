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
using System.Drawing;
using System.IO;

public partial class UC_Mang_News_deletenews : System.Web.UI.UserControl
{
    public int newsID
    {
        get
        {
            if (ViewState["newsID"] != null)
                return (int)ViewState["newsID"];
            else
                return -1;
        }
        set { ViewState["newsID"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (newsID < 0 && Request["page"] != null && Request["page"] == "delnews"
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
            NewsManager news = new NewsManager();
            news.NewsID = newsID;
            news.newsContextRead();
            lblMessage.Text = "آیا از حذف  خبری با عنوان \"  " + news.NewsName + "  \"اطمینان دارید ؟";
        }

    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        NewsManager news = new NewsManager();
        news.NewsID = newsID;
        news.newsContextRead();
        String path=Server.MapPath(news.imageName);
        int result = news.newsRemove();
        if (result == 1)
        {
            File.Delete(path);
            lblMessage.Text = "خبر با موفقیت حذف شد";
            lblMessage.ForeColor = Color.Blue;
            btnDel.Visible = false;
            Button1.Text = "باز گشت به  مدیریت  خبر";

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=newsmanag");
    }
}
