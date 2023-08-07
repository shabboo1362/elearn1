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

public partial class UC_Mang_course_addcourse : System.Web.UI.UserControl
{
    Course course = new Course();
    Reshte reshte = new Reshte();
    CourseType type = new CourseType();
    protected void Page_Load(object sender, EventArgs e)
    {
        reshtecodeddl.DataSource = reshte.allReshteName();
        reshtecodeddl.DataBind();
        coursetypeddl.DataSource = type.allCourseTypeIdName();
        coursetypeddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ValidationSummary1.Page.IsValid)
        {

            course.CodeReshte = reshtecodeddl.SelectedValue.ToString();
            course.CourseType = coursetypeddl.SelectedValue.ToString();
            course.CourseCode=coursecodetxt.Text.ToString();
            course.CourseName=coursenametxt.Text.ToString();
            if (nunittxt.Text!= "")
                course.NUnit= float.Parse(nunittxt.Text.ToString());
            if (aunittxt.Text != "")
                course.AUnit = float.Parse(aunittxt.Text.ToString());
            if (passgreadtxt.Text != "")
                course.PassGread = float.Parse(passgreadtxt.Text.ToString());
                int result = course.newCourse();
                if (result == 1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/succes.gif";
                    lblMessage.ForeColor = Color.Blue;
                    lblMessage.Text = "درس جدید با موفقیت به تعریف شد";
                    
                }
                else if (result == -1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "نوع درس وارده در سيستم وجود ندارد";
                }
                else if (result == -2)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "كد رشته وارده در سيستم وجود ندارد";
                }
                else
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "خطا در تعریف درس جدید- کد درس تکراری است.";
                }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
