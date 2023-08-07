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

public partial class UC_Mang_dore_doremanag : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvPageManag .DataSource= dore.allDoreh();
        gvPageManag.DataBind();
    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string codedore = (row.FindControl("lblcodedore") as Label).Text;
        string term = (row.FindControl("txtterm") as TextBox).Text;
        string year = (row.FindControl("txtyear") as TextBox).Text;
        if (term != "" && year != "")
        {
            dore.COdeDore = codedore;
            dore.TErm =byte.Parse(term);
            dore.YEar = int.Parse(year);
            int result = dore.updateDoreh();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "دوره با موفقيت ويرايش شد.";
                //imgSuccess.ImageUrl = "../../../images/succes.GIF";
                //imgSuccess.Visible = true;
                gvPageManag.EditIndex = -1;
            }
            //else if (result == -1)
            //{
            //    lblMessage.Text = "درس ديگري با اين كد وجود دارد";
            //    imgSuccess.ImageUrl = "../../../images/error.gif";
            //    imgSuccess.Visible = true;
            //    return;
            //}
            else if (result == -2)
            {
                lblMessage.Text = "خطا در ویرایش . خطای پایگاه داده";
                //imgSuccess.ImageUrl = "../../../images/error.gif";
                //imgSuccess.Visible = true;
                return;
            }
        }
        else
        {
            lblMessage.Text = " اطلاعات وارد شده درست نمي باشد";
            //imgSuccess.ImageUrl = "../../../images/error.gif";
            //imgSuccess.Visible = true;
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
