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

public partial class ControlPanel_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["page"] != null && Request["page"] == "logout")
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../index.aspx");

        }
        if (!Page.User.IsInRole("admin"))
        {
            Response.Redirect("../login.aspx?ReturnUrl=./ControlPanel/index.aspx");
        }
        
    }
}
