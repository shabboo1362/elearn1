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

public partial class UC_Mang_coursetype_deletecoursetype : System.Web.UI.UserControl
{
    public CourseType coursetype = new CourseType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Request["id"] != "")
        {

                coursetype.COurseType= Page.Request["id"].ToString();
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "¬Ì« «“ Õ–› ‰Ê⁄ œ—” " + coursetype.COurseType + " «ÿ„Ì‰«‰ œ«—Ìœ ";
        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
        }
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int result=coursetype.deleteCourseType();
       if (result == -2)
      {
          imSuccess.Visible = true;
          imSuccess.ImageUrl = "../../../images/error.gif";
          lblMessage.Text = "Œÿ« œ— Å«Ìê«Â œ«œÂ";
      }
      else if(result== 1)
      {
          imSuccess.Visible = true;
          imSuccess.ImageUrl = "../../../images/error.gif";
          lblMessage.Text = "‰Ê⁄ œ—” „Ê—œ‰Ÿ— »« „Ê›ﬁÌ  Õ–› ê—œÌœ ";
      }
          btnDel.Visible = false;
          Button1.Text = "»«“ê‘  »Â ’›ÕÂ „œÌ—Ì ";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
