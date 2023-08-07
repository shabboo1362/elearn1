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

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request["id"] != null && Request["id"] !="")
        {
            
                Control newsDetil = LoadControl("UC/Public/News/pageContext.ascx") ;
                phContent.Controls.Add(newsDetil) ;
        }
        else
        {

            Control home = LoadControl("UC/Public/News/topNewsHome.ascx");
            phContent.Controls.Add(home);
        }

    }
}
