using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class UC_Mang_ecourse_addecourse : System.Web.UI.UserControl
{
    public Course course = new Course();
    public Master master = new Master();
    public Doreh dore = new Doreh();
    public ECourse ecourse = new ECourse();
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodeddl.DataSource = dore.allDoreh();
        dorecodeddl.DataBind();
        coursecodeddl.DataSource = course.allCourseIdName();
        coursecodeddl.DataBind();
        mastercodeddl.DataSource = master.allMaster();
        mastercodeddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {

            ecourse.CodeDore = dorecodeddl.SelectedValue;
            ecourse.CourseCode = coursecodeddl.SelectedValue;
            ecourse.MasterCode = mastercodeddl.SelectedValue;
            if (capasitytxt.Text != "")
                ecourse.Capacity = int.Parse(capasitytxt.Text.ToString());
            if (pdp.Text != "")
                ecourse.ExamDate = pdp.PersianDateString;
            if (examtimetxt.Text != "")
                ecourse.ExamTime =examtimetxt.Text.ToString();
            int result = ecourse.newECourse();
            if (result == 1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/succes.gif";
                    lblMessage.ForeColor = Color.Blue;
                    lblMessage.Text = "درس جدید براي ارائه با موفقیت ثبت شد";
                   
                }
                else if (result == -1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "";
                }
                else
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "خطا در تعریف درس.";
                }
            }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
