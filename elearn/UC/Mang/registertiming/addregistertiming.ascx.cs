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

public partial class UC_Mang_registertiming_addregistertiming : System.Web.UI.UserControl
{
    public Doreh dore= new Doreh();
    public RegisterTiming registert = new RegisterTiming();
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodeddl.DataSource=dore.allDoreh();
        dorecodeddl.DataBind();
        vorodiddl.DataSource = dore.allDoreh();
        vorodiddl.DataBind();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {
            registert.DorehCode=dorecodeddl.SelectedValue;
            registert.RegBeginDate=rbeginpdp.PersianDateString;
            registert.RegExpDate = rexppdp.PersianDateString;
            registert.AddRemBeginDate = arbegindpdp.PersianDateString;
            registert.AddRemExpDate =arexppdp.PersianDateString;
            registert.EmgRemBeginDate = erbeginpdp.PersianDateString;
            registert.EmgRemExpDate = erexppdp.PersianDateString;
            registert.InputDorehCode = vorodiddl.SelectedValue;
            int result = registert.newRegTiming();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "زمانبندي جديد با موفقیت ثبت شد";
            }
            else if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "كد ورودي تكراري است";
            }
            else if (result == 0)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "خطا در مقادير ورودي.";
            }
            else if (result == -2)
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
