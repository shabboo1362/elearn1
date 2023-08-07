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

public partial class UC_Mang_dore_deletdore : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "")
        {

            dore.COdeDore = Page.Request["id"].ToString();
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "¬Ì« «“ Õ–› œÊ—Â " + dore.COdeDore + " «ÿ„Ì‰«‰ œ«—Ìœ ";
        
        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
        }
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int result = dore.deleteDoreh();
        if (result == -2)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "Œÿ« œ— Å«Ìê«Â œ«œÂ";
        }
        else if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "œÊ—Â „Ê—œ‰Ÿ— »« „Ê›ﬁÌ  Õ–› ê—œÌœ ";
        }
        else if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "«Ì‰ ﬂœ œÊ—Â „Ê—œ «—Ã«⁄ œ— Ãœ«Ê· œÌê— «”  ";
        }
        btnDel.Visible = false;
        Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
