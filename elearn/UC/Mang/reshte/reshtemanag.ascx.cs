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

public partial class UC_Mang_reshte_reshtemanag : System.Web.UI.UserControl
{
    public Reshte reshte = new Reshte();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvPageManag.DataSource =reshte.allReshteName();
        gvPageManag.DataBind();
    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string code = (row.FindControl("lblreshte") as Label).Text;
        string name = (row.FindControl("namereshte") as TextBox).Text;
        string maghtaname = (row.FindControl("lblmaghtaname") as Label).Text;
        string vomomi = (row.FindControl("vomomi") as TextBox).Text;
        string vtz = (row.FindControl("vtz") as TextBox).Text;
        string vte = (row.FindControl("vte") as TextBox).Text;
        if (code != "" && name != "")
        {
            reshte.codeReshte = code;
            reshte.name = name;
            reshte.nameMaghtaa = maghtaname;
            reshte.vahedOmoomi =float.Parse(vomomi);
            reshte.vahedTE = float.Parse(vte);
            reshte.vahedTZ = float.Parse(vtz);
            int result = reshte.updateReshte();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "رشته با موفقيت ويرايش شد.";
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
