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

public partial class UC_Mang_master_mastermanag : System.Web.UI.UserControl
{
    public Master master = new Master();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        gvPageManag.DataSource = master.allMaster();
        gvPageManag.DataBind();
    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string code = (row.FindControl("codestudent") as Label).Text;
        string name = (row.FindControl("name") as TextBox).Text;
        string family = (row.FindControl("family") as TextBox).Text;
        string father = (row.FindControl("father") as TextBox).Text;
        string codemail = (row.FindControl("codemail") as TextBox).Text;
        string shshenasname = (row.FindControl("shshenasnameh") as TextBox).Text;
        string address = (row.FindControl("address") as TextBox).Text;
        string tel = (row.FindControl("tel") as TextBox).Text;
        string reshte = (row.FindControl("reshte") as TextBox).Text;
        string codereshte = (row.FindControl("codereshte") as TextBox).Text;
        string usertype = (row.FindControl("usertype") as TextBox).Text;
        string lastg = (row.FindControl("lastg") as TextBox).Text;
        if (code != "" && name != "" && family != "" && father != "" && codemail != "" && shshenasname != "" && 
            address != ""  && lastg != "" && reshte != "" && codereshte != "")
        {
            master.UserCode = code;
            master.Name = name;
            master.Family = family;
            master.Father = father;
            master.CodeMelli = codemail;
            master.ShShenasnameh = shshenasname;
            master.Address = address;
            master.Tel = tel;
            master.Reshte = reshte;
            master.CodeReshte = codereshte;
            master.TypeUser= usertype;
            master.LastGrade = lastg;
            int result = master.updateMaster();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "مدرس با موفقيت ويرايش شد.";
                imSuccess.ImageUrl = "../../../images/succes.GIF";
                imSuccess.Visible = true;
                gvPageManag.EditIndex = -1;
            }
            else if (result == 0)
            {
                lblMessage.Text = " اطلاعات وارد شده درست نمي باشد";
                imSuccess.ImageUrl = "../../../images/error.gif";
                imSuccess.Visible = true;
                return;
            }
            else if (result == -1)
            {
                lblMessage.Text = " اين كد در جداول ديگر مورد ارجاع است و قابل ويرايش نمي باشد";
                imSuccess.ImageUrl = "../../../images/error.gif";
                imSuccess.Visible = true;
                return;
            }
            else if (result == -2)
            {
                lblMessage.Text = "خطا در ویرایش . خطای پایگاه داده";
                imSuccess.ImageUrl = "../../../images/error.gif";
                imSuccess.Visible = true;
                return;
            }
        }
        else
        {
            lblMessage.Text = " اطلاعات وارد شده درست نمي باشد";
            imSuccess.ImageUrl = "../../../images/error.gif";
            imSuccess.Visible = true;
            return;
        }
    }
    protected void gvPageManag_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvPageManag.EditIndex = e.NewEditIndex;
    }
    protected void gvPageManag_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvPageManag.EditIndex = -1;
    }
    protected void gvPageManag_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPageManag.PageIndex = e.NewPageIndex;
    }
}
