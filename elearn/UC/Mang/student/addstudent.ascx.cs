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

public partial class UC_Mang_student_addstudent : System.Web.UI.UserControl
{
    public Reshte reshte = new Reshte();
    public Doreh dore = new Doreh();
    public Students student = new Students();
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodddl.DataSource = dore.allDoreh();
        dorecodddl.DataBind();
        reshtecodeddl.DataSource = reshte.allCodeReshte();
        reshtecodeddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {
            if (Membership.GetUser(usercodetxt.Text) != null)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "کاربری با این نام موجود می باشد.";
                return;
            }
            string defaultEmail = ConfigurationManager.AppSettings["DefaultEmail"].ToString();
            //======================================================================
            MembershipUser user =
                Membership.CreateUser(usercodetxt.Text, codemelitxt.Text, defaultEmail);
            if (user != null)
            {
                string[] users = { user.UserName };
                Roles.AddUsersToRole(users, "student");


                student.address = addresstxt.Text.ToString();
                student.tarikh_t = tarikhttxt.Text;
                student.codeMelli = codemelitxt.Text.ToString();
                student.codeReshte = reshtecodeddl.SelectedValue.ToString();
                student.family = familytxt.Text.ToString();
                student.father = fathertxt.Text.ToString();
                student.name = nametxt.Text.ToString();
                student.codeReshte = reshtecodeddl.SelectedValue.ToString();
                student.shShenasNameh = shshtxt.Text.ToString();
                student.codeStudent = usercodetxt.Text.ToString();
                student.codeDore = dorecodddl.SelectedValue.ToString();
                if (teltxt.Text != "")
                    student.tel = teltxt.Text.ToString();

                int result = student.newStudent();
                if (result == 1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/succes.gif";
                    lblMessage.ForeColor = Color.Blue;
                    lblMessage.Text = "كاربر جدید با موفقیت ثبت شد";
                }
                else if (result == -1)
                {
                    imSuccess.Visible = true;
                    imSuccess.ImageUrl = "../../../images/error.gif";
                    lblMessage.Text = "شماره كاربري تكراري است";
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
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
