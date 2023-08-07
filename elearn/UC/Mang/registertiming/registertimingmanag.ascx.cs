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

public partial class UC_Mang_registertiming_registertimingmanag : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    public RegisterTiming registert = new RegisterTiming();
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodeddl.DataSource = dore.allDoreh();
        dorecodeddl.DataBind();
        registert.DorehCode = dorecodeddl.SelectedValue;
        gvPageManag.DataSource = registert.allRegTiming();
        gvPageManag.DataBind();
    }
    protected void searchbtn_Click(object sender, EventArgs e)
    {
        registert.DorehCode = dorecodeddl.SelectedValue;
        gvPageManag.DataSource = registert.allRegTiming();
        gvPageManag.DataBind();
    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        registert.DorehCode = dorecodeddl.SelectedValue;
        //----------------------------------------------------------    Retrieve New Values
        string input = (row.FindControl("lblinput") as Label).Text;
        
        string pdpr = (row.FindControl("pdpr") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        string pdpr1 = (row.FindControl("lblr") as Label).Text;
        string pdprexp = (row.FindControl("pdprexp") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        string pdprexp1 = (row.FindControl("lblrexp") as Label).Text;
        string pdpar = (row.FindControl("pdpar") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        string pdpar1 = (row.FindControl("lblar") as Label).Text;
        string pdparexp = (row.FindControl("pdparexp") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        string pdparexp1 = (row.FindControl("lblarexp") as Label).Text;
        string pdpe = (row.FindControl("pdpe") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        string pdpe1 = (row.FindControl("lble") as Label).Text;
        string pdpeexp1 = (row.FindControl("lbleexp") as Label).Text;
        string pdpeexp = (row.FindControl("pdpeexp") as AspNetPersianDatePickup.PersianDatePickup).PersianDateString;
        if (input != "" && registert.DorehCode != "" )
        {
            
            registert.InputDorehCode= input;
            if (pdpr!="")
            registert.RegBeginDate = pdpr;
            else
            registert.RegBeginDate = pdpr1;
            if (pdprexp != "")
            registert.RegExpDate =pdprexp;
            else
            registert.RegExpDate = pdprexp1;
            if (pdpar != "")
            registert.AddRemBeginDate = pdpar;
            else
            registert.AddRemBeginDate = pdpar1;
            if (pdparexp != "")
            registert.AddRemExpDate = pdparexp;
            else
            registert.AddRemExpDate = pdparexp1;
            if (pdpe != "")
            registert.EmgRemBeginDate =pdpe;
            else
            registert.EmgRemBeginDate = pdpe1;
            if (pdpeexp != "")
            registert.EmgRemExpDate = pdpeexp;
            else
            registert.EmgRemExpDate = pdpeexp1;
            int result = registert.updateRegTiming();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = " با موفقيت ويرايش شد.";
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
