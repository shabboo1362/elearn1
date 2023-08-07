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

public partial class UC_Mang_registertiming_delregistertiming : System.Web.UI.UserControl
{
    public RegisterTiming regt = new RegisterTiming();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "" && Page.Request["id1"].ToString()!="")
        {

            regt.DorehCode = Page.Request["id"].ToString();
            regt.InputDorehCode = Page.Request["id1"].ToString();
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "آیا از  حذف زمانبندی  دوره  " + regt.DorehCode+ "  برای  وردی های    " + regt.InputDorehCode+" اطمینان دارید ";

        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "بازگشت به مدیریت زمانبندی ثبت نام";
        }
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        regt.DorehCode = Page.Request["id"].ToString();
        regt.InputDorehCode = Page.Request["id1"].ToString();
        int result = regt.deleteRegTiming();
        if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/succes.gif";
            lblMessage.Text = " حذف با موفقیت انجام شد";
        }
        else 
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "خطا در حذف زمانبندی  ";
        }
        btnDel.Visible = false;
        Button1.Text = "بازگشت به مدیریت زمانبندی ثبت نام";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx?page=managregtiming");
    }
}
