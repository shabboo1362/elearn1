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

public partial class UC_Mang_coursepish_pishmanag : System.Web.UI.UserControl
{
    public Course course = new Course();
    public CoursePish coursepish = new CoursePish();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            coursecodeddl.DataSource = course.allCourseIdName();
            coursecodeddl.DataBind();
        }
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        
        
        coursecode.DataSource = course.allCourseIdName();
        coursecode.DataBind();
    }
    protected void searchbtn_Click(object sender, EventArgs e)
    {
        fillgrid();
    }
    protected void addbtn_Click(object sender, EventArgs e)
    {

        coursepish.CourseCode = coursecodeddl.SelectedValue;
        coursepish.CoursePishCode = coursecode.SelectedValue;

        coursepish.Type =byte.Parse(typeddl.SelectedValue.ToString());
        int result= coursepish.newCoursePish();
        if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/succes.gif";
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "عمليات باموفقیت انجام شد";
           
        }
        else if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = " قبلاَ براي اين درس پيشنياز شده است";
        }
        else if (result == -4)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = " یک درس نمی تواند پیش نیاز خود باشد";
        }
        else
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "خطا در پايگاه داده يا آرگومان هاي لازم.";
        }
        fillgrid();
    }
    public void fillgrid()
    {
        coursepish.CourseCode = coursecodeddl.SelectedValue;
        Label2.Text = coursecodeddl.SelectedValue;
        gvPageManag.DataSource = coursepish.allCoursePish();
        gvPageManag.DataBind();

    }
    protected void gvPageManag_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        coursepish.CoursePishCode = (row.FindControl("lblcoursecode") as Label).Text;
        coursepish.CourseCode = coursecodeddl.SelectedValue;
        int result = coursepish.deleteCoursePish();
        if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/succes.gif";
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "عمليات حذف باموفقیت انجام شد";
            fillgrid();

        }
        else
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = " خطا در اتصال به پايگاه داده";
        }
    }
}
