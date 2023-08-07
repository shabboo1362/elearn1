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

public partial class UC_Mang_course_deletecourse : System.Web.UI.UserControl
{
    public Course course = new Course();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "")
        {
            
            course.CourseCode = Page.Request["id"].ToString();
            int result=course.courseInfo();
            if (result == -1)
            {
                //imSuccess.Visible = true;
                //imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "كد درس وارده در سيستم وجود ندارد";
                btnDel.Visible = false;
                Button1.Text = "بازگشت به صفحه مديريت";
            }
            else
            {
                //imSuccess.Visible = true;
                //imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = " توجه:با حذف یک درس تمام اطلاعات آن از سیستم حذف می شود ايا از حذف درس ."+course.CourseName+"  با كد درس  "+course.CourseCode+" اطمينان داريد ";
            }
        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "بازگشت به صفحه مديريت";
        }
                
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
      int result=course.deleteCourse();
      if (result == -1)
      {
          //imSuccess.Visible = true;
          //imSuccess.ImageUrl = "../../../images/error.gif";
          lblMessage.Text = "اين درس قابل حذف نميباشد زيرا در جداول ديگر مورد ارجاع قرار گرفته است";
      }
      else if (result == -2)
      {
          //imSuccess.Visible = true;
          //imSuccess.ImageUrl = "../../../images/error.gif";
          lblMessage.Text = "خطا در پايگاه داده";
      }
      else if(result== 1)
      {
          //imSuccess.Visible = true;
          //imSuccess.ImageUrl = "../../../images/error.gif";
          lblMessage.Text = "درس موردنظر با موفقيت حذف گرديد ";
      }
        btnDel.Visible = false;
          Button1.Text = "بازگشت به صفحه مديريت";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=coursemanag");
    }
}
