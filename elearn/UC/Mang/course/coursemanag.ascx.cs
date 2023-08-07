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

public partial class UC_Mang_course_coursemanag : System.Web.UI.UserControl
{
    public Reshte reshte = new Reshte();
    public Course course = new Course();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        codereshteddl.DataSource = reshte.allReshteName();
        codereshteddl.DataBind();
        course.CodeReshte = codereshteddl.SelectedValue;
        gvPageManag.DataSource = course.allCourse();
        gvPageManag.DataBind();
    }

    protected void search_Click(object sender, EventArgs e)
    {
        if (coursecodetxt.Text != "")
            course.CourseCode = coursecodetxt.Text;
        course.CodeReshte = codereshteddl.SelectedValue;
        gvPageManag.DataSource = course.allCourse();
        gvPageManag.DataBind();

    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        string name = (row.FindControl("name") as TextBox).Text;
        string ccode = (row.FindControl("ccode") as Label).Text;
        string rcode = (row.FindControl("rcode") as TextBox).Text;
        string type = (row.FindControl("type") as TextBox).Text;
        if (name!= "" && ccode!="" )
        {
            if ((row.FindControl("passgread") as TextBox).Text != "")
                course.PassGread = float.Parse((row.FindControl("passgread") as TextBox).Text);
            if ((row.FindControl("nunit") as TextBox).Text != "")
                course.NUnit = float.Parse((row.FindControl("nunit") as TextBox).Text);
            if ((row.FindControl("aunit") as TextBox).Text != "")
                course.AUnit =float.Parse((row.FindControl("aunit") as TextBox).Text);
            course.CourseName =name;
            course.CourseCode = ccode;
            course.CodeReshte = rcode;
            course.CourseType = type;
            int result = course.updateCourse();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "درس با موفقيت ويرايش شد.";
                imSuccess.ImageUrl = "../../../images/succes.GIF";
                imSuccess.Visible = true;
                gvPageManag.EditIndex = -1;
                 }
            else if (result == -1)
            {
                lblMessage.Text = "نوه درس موجود نمی باشد";
                imSuccess.ImageUrl = "../../../images/error.gif";
                imSuccess.Visible = true;
                return;
            }
            else if (result == -2)
            {
                lblMessage.Text = "رشته موجود نمی باشد";
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
