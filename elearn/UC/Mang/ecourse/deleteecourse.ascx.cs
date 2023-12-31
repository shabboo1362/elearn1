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

public partial class UC_Mang_ecourse_deleteecourse : System.Web.UI.UserControl
{
    ECourse ecourse = new ECourse();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "")
        {

            ecourse.Id =int.Parse(Page.Request["id"].ToString());
            int result = ecourse.eCourseInfo();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "آیا از حذف درس ارائه شده  " + ecourse.CourseName + " با کد " + ecourse.CourseCode + " اطمینان دارید؟ ";
            }

        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "بازگشت به مدیریت دروس ارائه شده";
        }
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int result = ecourse.deleteECourse();
        if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "این درس در جدول های دیگر مورد ارجاع است و حذف آن امکانپذیر نیست";
        }
        else if (result == -2)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "خطای پایگاه د اده ";
        }
        else if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = " درس با موفقیت حدف شد ";
        }
        btnDel.Visible = false;
        Button1.Text = "بازگشت به مدیریت دروس ارائه شده";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=ecoursemanag");
    }
}
