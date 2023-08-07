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

public partial class UC_Mang_Maghtaa_addmaghtaa : System.Web.UI.UserControl
{
    public Maghtaa maghta = new Maghtaa();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {
            maghta.maxVahedA = float.Parse(maxvatxt.Text.ToString());
            maghta.maxVahedG = float.Parse(maxvgtxt.Text.ToString());
            maghta.maxVmashrooti = float.Parse(maxvmtxt.Text.ToString());
            maghta.minVahed = float.Parse(minvahedtxt.Text.ToString());
            maghta.moadelA = float.Parse(moadelatxt.Text.ToString());
            maghta.moadelMashrooti = float.Parse(moadelmtxt.Text.ToString());
            maghta.nameMaghtaa = namemaghtaatxt.Text.ToString();
            int result = maghta.newMaghtaa();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "مقطع جدید با موفقیت ثبت شد";
               
            }
            else if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "نام مقطع تكراري است";
            }
            else if (result == 0)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "خطا در مقادير ورودي.";
            }
            else if (result == -4)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "خطا در اتصال به پايگاه داده.";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
