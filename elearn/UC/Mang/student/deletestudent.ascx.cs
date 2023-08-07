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

public partial class UC_Mang_student_deletestudent : System.Web.UI.UserControl
{
    public Students student = new Students();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.Request["id"] != "")
        {
            student.codeStudent = Page.Request["id"].ToString();
            int result = student.StudentInfo();
            if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "دانشجويي با اين كد كاربري در سيستم وجود ندارد";
                btnDel.Visible = false;
                Button1.Text = "بازگشت به صفحه مديريت";
            }
            else
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "با حذف یک دانشجو تمام اطلاعات آن از سیستم حذف می شود .ايا از حذف دانشجو با شماره كاربري" + student.codeStudent + "  اطمينان داريد.";
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

        int result = student.deleteStudent();
        if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "اين دانشجو قابل حذف نميباشد زيرا در جداول ديگر مورد ارجاع قرار گرفته است";
        }
        else if (result == -2)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "خطا در پايگاه داده";
        }
        else if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "دانشجو موردنظر با موفقيت حذف گرديد ";
        }
        btnDel.Visible = false;
        Button1.Text = "بازگشت به صفحه مديريت";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
