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

public partial class UC_Mang_master_deletemasterl : System.Web.UI.UserControl
{
    Master master = new Master();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.Request["id"] != "")
        {
            master.UserCode = Page.Request["id"].ToString();
            int result=master.MasterInfo();
            if(result==-1)
            {
                imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "كاربري با اين كد كاربري در سيستم وجود ندارد";
            btnDel.Visible = false;
            Button1.Text = "بازگشت به صفحه مديريت";
            }
            else
            {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text ="با حذف یک كاربر تمام اطلاعات آن از سیستم حذف می شود .ايا از حذف كاربر با شماره كاربري"+master.UserCode+"  اطمينان داريد.";
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
        int result = master.deleteMaster();
        if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "اين كاربر قابل حذف نميباشد زيرا در جداول ديگر مورد ارجاع قرار گرفته است";
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
            lblMessage.Text = "كاربر موردنظر با موفقيت حذف گرديد ";
            Membership.DeleteUser(master.UserCode );
        }
        btnDel.Visible = false;
        Button1.Text = "بازگشت به صفحه مديريت";
    }
    protected void  Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=managmaster");
    }
}
