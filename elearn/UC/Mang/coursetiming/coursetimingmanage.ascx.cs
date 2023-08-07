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

public partial class UC_Mang_coursetiming_coursetimingmanage : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    public ECourse ecourse = new ECourse();
    protected void Page_Load(object sender, EventArgs e)
    {
        doreddl.DataSource = dore.allDoreh();
        doreddl.DataBind();
        coursecodeddl.DataSource = ecourse.allECourseIdNameB();
        coursecodeddl.DataBind();
    }
}
