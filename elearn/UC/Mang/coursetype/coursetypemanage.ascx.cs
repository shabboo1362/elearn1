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

public partial class UC_Mang_coursetype_coursetypemanage : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    public CourseType coursetype = new CourseType();
    protected void Page_Load(object sender, EventArgs e)
    {
        dorecodeddl.DataSource = dore.allDoreh();
        dorecodeddl.DataBind();
        coursetype.CodeDore = dorecodeddl.SelectedValue;
        gvPageManag.DataSource = coursetype.allCourseType();
        gvPageManag.DataBind();
    }

    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string tuition = (row.FindControl("txttuition") as TextBox).Text;
        string ctype = (row.FindControl("txtcoursetype") as TextBox).Text;
        if (ctype != "" && tuition!= "")
        {
            coursetype.CodeDore = dorecodeddl.SelectedValue;
            coursetype.CourseTuition =decimal.Parse(tuition);
            coursetype.NewcourseType = ctype;
            int result = coursetype.updateCourceType();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "نوع درس با موفقيت ويرايش شد.";
                //imgSuccess.ImageUrl = "../../../images/succes.GIF";
                //imgSuccess.Visible = true;
                gvPageManag.EditIndex = -1;
            }
            else if (result == -1)
            {
                lblMessage.Text = "نوع درس ديگري با اين كد وجود دارد";
                //imgSuccess.ImageUrl = "../../../images/error.gif";
                //imgSuccess.Visible = true;
                return;
            }
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
        //GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //string ctype = (row.FindControl("lblcoursetype") as Label).Text;
        //coursetype.COurseType = ctype;
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
    protected void searchbtn_Click(object sender, EventArgs e)
    {
        coursetype.CodeDore = dorecodeddl.SelectedValue;
        gvPageManag.DataSource = coursetype.allCourseType();
        gvPageManag.DataBind();
    }
}
