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

public partial class UC_Mang_student_studentmanag : System.Web.UI.UserControl
{
    public Students student = new Students();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvPageManag.DataSource = student.allStudent();
        gvPageManag.DataBind();
    }

    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string code = (row.FindControl("lblcodestudent") as Label).Text;
        string name = (row.FindControl("name") as TextBox).Text;
        string family = (row.FindControl("family") as TextBox).Text;
        string father = (row.FindControl("father") as TextBox).Text;
        string codemail = (row.FindControl("codemail") as TextBox).Text;
        string shshenasname = (row.FindControl("shshenasnameh") as TextBox).Text;
        string address = (row.FindControl("address") as TextBox).Text;
        string tel = (row.FindControl("tel") as TextBox).Text;
        string codereshte = (row.FindControl("lblcodeReshteh") as Label).Text;
        string tarikht = (row.FindControl("tarikht") as TextBox).Text;
        string codeDore = (row.FindControl("lblcodeDore") as Label).Text;
        if (code != "" && name != "" && family != "" && father != "" && codemail != "" && shshenasname != "" && address != "" && codereshte != "" && codeDore != "" && tarikht != "")
        {
            student.codeStudent = code;
            student.name = name;
            student.family = family;
            student.father = father;
            student.codeMelli = codemail;
            student.shShenasNameh = shshenasname;
            student.address = address;
            student.tel = tel;
            student.codeReshte = codereshte;
            student.tarikh_t = tarikht;
            student.codeDore = codeDore;
            int result = student.updateStudent();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "دانشجو با موفقيت ويرايش شد.";
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
