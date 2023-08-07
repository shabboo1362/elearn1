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

public partial class UC_Public_MainPage_pageContext : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int pageId = 0;
            if (Request["id"] != null)
            {
                try
                {

                    string req = Request["id"];
                    NewsManager manager = new NewsManager();
                    manager.NewsID = Convert.ToInt32(req);
                    manager.newsContextRead();
                    lblContent.Text = manager.Context;
                    lblTitle.Text = manager.NewsName;

                    
                }
                catch
                {
                    Response.Redirect("~/errorPage.aspx?error=BadIDPageContext");
                }

            }
        }
    }
}
