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

public partial class UC_Mang_reshte_addreshte : System.Web.UI.UserControl
{
    public Maghtaa maghtaa = new Maghtaa();
    public Reshte reshte = new Reshte();
    protected void Page_Load(object sender, EventArgs e)
    {
        maghtaanameddl.DataSource = maghtaa.allNameMaghtaa();
        maghtaanameddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {
            reshte.codeReshte = reshtecodetxt.Text.ToString();
            reshte.name = reshtenametxt.Text.ToString();
            reshte.nameMaghtaa = maghtaanameddl.SelectedValue;
            reshte.vahedOmoomi =float.Parse(vomomitxt.Text.ToString());
            reshte.vahedTE = float.Parse(vekhtiaritxt.Text.ToString());
            reshte.vahedTZ = float.Parse(vtakhasisitxt.Text.ToString());
            int result = reshte.newReshte();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "رشته جدید با موفقیت ثبت شد";
            }
            else if (result == -1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "كد رشته تكراري است";
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
                lblMessage.Text = "نام رشته تكراري است.";
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
