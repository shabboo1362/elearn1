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

public partial class UC_Mang_master_addmaster : System.Web.UI.UserControl
{
    public Master master = new Master();
    public Reshte reshte = new Reshte();
    protected void Page_Load(object sender, EventArgs e)
    {
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
                Membership.CreateUser(usercodetxt.Text, codemelitxt.Text ,defaultEmail );
            if (user != null)
            {
                string[] users = { user.UserName };
                Roles.AddUsersToRole(users ,usertypeddl.SelectedValue ) ;

                //=========================================================================


                master.Address = addresstxt.Text.ToString();
                master.CodeMelli = codemelitxt.Text.ToString();
                master.CodeReshte = reshtecodeddl.SelectedValue.ToString();
                master.Family = familytxt.Text.ToString();
                master.Father = fathertxt.Text.ToString();
                master.LastGrade = lastgradetxt.Text.ToString();
                master.Name = nametxt.Text.ToString();
                master.Reshte = reshtetxt.Text.ToString();
                master.ShShenasnameh = shshtxt.Text.ToString();
                master.TypeUser = usertypeddl.SelectedValue.ToString();
                master.UserCode = usercodetxt.Text.ToString();
                if (teltxt.Text != "")
                    master.Tel = teltxt.Text.ToString();
                else
                    master.Tel = "0" ;
                int result = master.newMaster();
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
            else
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "کاربری با این نام موجود می باشد.";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
