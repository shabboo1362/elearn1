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

public partial class UC_Mang_dore_adddore : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Doreh dore = new Doreh();
        if (ValidationSummary1.Page.IsValid)
        {

            dore.COdeDore = dorecodetxt.Text.ToString();
            dore.TErm =byte.Parse(termtxt.Text.ToString());
            dore.YEar=int.Parse(yeartxt.Text.ToString());
            if (rbtnSta1.Checked)
                dore.Status = 2;
            else
                dore.Status = 3;
            int result =dore.newDoreh();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "دوره جدید با موفقیت به تعریف شد";
               
            }
            else if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "كد دوره وارده تكراري مي باشد";
            }
            else if (result == 0)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "مقادير ورودي نا معتبر مي باشد";
            }
            else if(result == -2)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "خطا در اتصال به پايگاه داده.";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
