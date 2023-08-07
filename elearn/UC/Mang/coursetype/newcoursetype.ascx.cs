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

public partial class UC_Mang_coursetype_newcoursetype : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    public CourseType coursetype = new CourseType();
    protected void Page_Load(object sender, EventArgs e)
    {
        codedoreddl.DataSource= dore.allDoreh();
        codedoreddl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidationSummary1.Page.IsValid)
        {

            coursetype.CodeDore= codedoreddl.SelectedValue.ToString();
            coursetype.COurseType = coursetypetxt.Text.ToString();
            coursetype.CourseTuition =decimal.Parse(coursetutiontxt.Text.ToString());
            int result = coursetype.newCourseType();
            if (result == 1)
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/succes.gif";
                lblMessage.ForeColor = Color.Blue;
                lblMessage.Text = "نوع درس جدید با موفقیت به تعریف شد";
               
            }
            else
            {
                imSuccess.Visible = true;
                imSuccess.ImageUrl = "../../../images/error.gif";
                lblMessage.Text = "خطا در اتصال به پايگاه داده.";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
