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

public partial class UC_Mang_reshte_deletereshte : System.Web.UI.UserControl
{
    public Reshte reshte = new Reshte();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "")
        {
            reshte.codeReshte= Page.Request["id"].ToString();
            int result = reshte.ReshteInfo();
            if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "اين كد رشته در سيستم وجود ندارد"
                    + Page.Request["id"].ToString();
                btnDel.Visible = false;
                Button1.Text = "بازگشت به صفحه مديريت";
            }
            else
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "با حذف یک رشته تمام اطلاعات آن از سیستم حذف می شود .ايا از حذف رشته  " + reshte.name +"با كد رشته"+reshte.codeReshte+ "  اطمينان داريد.";
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
        int result = reshte.deleteReshte();
        if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "اين رشته قابل حذف نميباشد زيرا در جداول ديگر مورد ارجاع قرار گرفته است";
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
            lblMessage.Text = "مقطع موردنظر با موفقيت حذف گرديد ";
        }
        btnDel.Visible = false;
        Button1.Text = "بازگشت به صفحه مديريت";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
