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

public partial class UC_Mang_Maghtaa_maghtaamanag : System.Web.UI.UserControl
{
    public Maghtaa maghtaa = new Maghtaa();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvPageManag.DataSource=maghtaa.allMaghtaa();
        gvPageManag.DataBind();
    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string name = (row.FindControl("lblnamemaghtaa") as Label).Text;
        string minvahed = (row.FindControl("minvahed") as TextBox).Text;
        string moadela = (row.FindControl("moadela") as TextBox).Text;
        string moadelm = (row.FindControl("moadelm") as TextBox).Text;
        string maxvahedm = (row.FindControl("maxvahedm") as TextBox).Text;
        string maxvaheda = (row.FindControl("maxvaheda") as TextBox).Text;
        string maxvahedg = (row.FindControl("maxvahedg") as TextBox).Text;
        if (name != "" && minvahed != "" && moadela != "" && moadelm != "" && maxvahedm != "" && maxvaheda != "" && maxvahedg != "")
        {
            maghtaa.nameMaghtaa = name;
            maghtaa.minVahed =float.Parse(minvahed);
            maghtaa.moadelA =float.Parse(moadela);
            maghtaa.moadelMashrooti = float.Parse(moadelm);
            maghtaa.maxVahedA = float.Parse(maxvaheda);
            maghtaa.maxVmashrooti = float.Parse(maxvahedm);
            maghtaa.maxVahedG = float.Parse(maxvahedg);
            int result = maghtaa.updateMaghtaa();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "مقطع با موفقيت ويرايش شد.";
                imSuccess.ImageUrl = "../../../images/succes.GIF";
                imSuccess.Visible = true;
                gvPageManag.EditIndex = -1;
            }
            else if (result == -0)
            {
                lblMessage.Text = " اطلاعات وارد شده درست نمي باشد";
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
