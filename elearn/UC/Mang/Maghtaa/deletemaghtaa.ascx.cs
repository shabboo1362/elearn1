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

public partial class UC_Mang_Maghtaa_deletemaghtaa : System.Web.UI.UserControl
{
    public Maghtaa maghtaa = new Maghtaa();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.Request["id"] != "")
        {

            maghtaa.nameMaghtaa = Page.Request["id"].ToString();
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "¬Ì« «“ Õ–› „ﬁÿ⁄ " + maghtaa.nameMaghtaa + " «ÿ„Ì‰«‰ œ«—Ìœ ";

        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int result = maghtaa.deleteMaghtaa();
        if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "«Ì‰ „ﬁÿ⁄ ﬁ«»· Õ–› ‰„Ì»«‘œ “Ì—« œ— Ãœ«Ê· œÌê— „Ê—œ «—Ã«⁄ ﬁ—«— ê—› Â «” ";
        }
        else if (result == -2)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "Œÿ« œ— Å«Ìê«Â œ«œÂ";
        }
        else if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "„ﬁÿ⁄ „Ê—œ‰Ÿ— »« „Ê›ﬁÌ  Õ–› ê—œÌœ ";
        }
        btnDel.Visible = false;
        Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
    }
}
