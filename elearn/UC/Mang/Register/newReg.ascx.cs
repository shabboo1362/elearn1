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

public partial class UC_Mang_Register_newReg : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Students std = new Students();
        std.codeStudent = Page.User.Identity.Name;
        int resu = std.StudentInfo();

        Doreh doreh = new Doreh();
        int result  = doreh.dorehJari();
        if (result == 1)
        {
            RegisterTiming regTiming = new RegisterTiming();
            regTiming.InputDorehCode = std.codeDore;
            regTiming.DorehCode = doreh.COdeDore;
            regTiming.inputRegTimingInfo();

            string str = Setting.CurentDate();
            if (String.Compare(regTiming.RegBeginDate, Setting.CurentDate()) != 1
                && String.Compare(regTiming.RegExpDate, Setting.CurentDate()) != -1)
            {
                if (resu == 1)
                {
                    lblCodeMeli.Text = std.codeMelli;
                    lblfamily.Text = std.family;
                    lblName.Text = std.name;
                    lblfather.Text = std.father;
                    lblShSh.Text = std.shShenasNameh;
                    lblStdNo.Text = std.codeStudent;
                    lblTerm.Text  =""+ doreh.TErm;
                    lblYear.Text = ""+doreh.YEar;

                    ECourse ec = new ECourse();
                    DataTable dt = ec.allECourse_ForStudent(std.codeStudent);
                    gvAllCourse.DataSource = dt;
                    gvAllCourse.DataBind();
                }
            }
            else
            {
                lblMessage.Text = "زمان انتخاب واحد  نادرست";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void gvAllCourse_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row = gvAllCourse.Rows[e.NewSelectedIndex];

        Register register = new Register();
        register.codeStudent = lblStdNo.Text;
        register.courseEID = (row.FindControl("lblID") as Label).Text;
        int result = 1;// register.addNewCouse();
        if (result == 1)
        {
        }
        else
        {
        }

    }
}
