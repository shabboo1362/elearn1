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

public partial class UC_Public_News_studentNews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NewsManager manager = new NewsManager();
        DataTable dt = manager.topnews();
        gvPageManag.DataSource = dt;
        gvPageManag.DataBind();
    }
}
