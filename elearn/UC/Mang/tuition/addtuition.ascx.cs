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

public partial class UC_Mang_tuition_addtuition : System.Web.UI.UserControl
{
    private Reshte reshte = new Reshte();
    private Doreh dore = new Doreh();
    private Tuition tuition1=new Tuition();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodeddl.DataSource=dore.allDoreh();
        dorecodeddl.DataBind();
        vorodiddl.DataSource = dore.allDoreh();
        vorodiddl.DataBind();
        reshtecodeddl.DataSource= reshte.allCodeReshte();
        reshtecodeddl.DataBind();

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        if (ValidationSummary1.Page.IsValid)
        {

            tuition1.FiledCode = reshtecodeddl.SelectedValue;
            tuition1.PeriodCode = dorecodeddl.SelectedValue;
            tuition1.Tuitions=decimal.Parse(tuitiontxt.Text.ToString());
            int result =tuition1.newTuition();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "شهريه جدید با موفقیت به تعریف شد";
               
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
protected void  btnCancel_Click(object sender, EventArgs e)
{
    Response.Redirect("./manag.aspx");
}
}
