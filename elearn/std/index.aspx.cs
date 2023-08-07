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

public partial class std_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["page"] != null && Request["page"] == "singout")
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../index.aspx");

        }
        if (!Page.User.IsInRole("student"))
        {
            Response.Redirect("../login.aspx?ReturnUrl=./std/index.aspx");
        }
        if (!Page.IsPostBack)
        {
            Students std = new Students();
            std.codeStudent = Page.User.Identity.Name;
            std.StudentInfo();
            lblName.Text = std.name + "  " + std.family;
            lblNo.Text = std.codeStudent;
            lblStatus.Text = "1" ;

        }
        if (Request["page"] != null && Request["page"] != "")
        {
            string req = Request["page"];
            switch (req)
            {
                case "newReg":
                    Control newReg = LoadControl("../UC/Mang/Register/newReg.ascx");
                    phContent.Controls.Add(newReg);
                    break;
                

            }

        }
        else
        {
            Control home = LoadControl("../UC/Mang/student/stdHome.ascx");
            phContent.Controls.Add(home);
        }
    }
}
