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

public partial class UC_Mang_ecourse_ecoursemanag : System.Web.UI.UserControl
{
    public Doreh dore = new Doreh();
    public Course course = new Course();
    public ECourse ecourse = new ECourse();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            codedoreddl.DataSource = dore.allDoreh();
            codedoreddl.DataBind();
            coursecodeddl.DataSource = course.allCourseIdName();
            coursecodeddl.DataBind();
            
        }
        
    }
    protected void search_Click(object sender, EventArgs e)
    {

    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        ecourse.CodeDore = codedoreddl.SelectedValue;
        ecourse.CourseCode = coursecodeddl.SelectedValue;
        gvPageManag.DataSource = ecourse.allECourse();
        gvPageManag.DataBind();
        

    }
    protected void gvPageManag_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        GridViewRow row = gvPageManag.Rows[e.RowIndex];
        //----------------------------------------------------------    Retrieve New Values
        ecourse.CodeDore = (row.FindControl("dcode") as Label).Text;
        ecourse.CourseCode = (row.FindControl("ccode") as Label).Text;
        ecourse.MasterCode = (row.FindControl("mastercode") as TextBox).Text;
        if ((row.FindControl("capacity") as TextBox).Text != "")
            ecourse.Capacity = int.Parse((row.FindControl("capacity") as TextBox).Text.ToString());
        if ((row.FindControl("examdate") as TextBox).Text != "")
            ecourse.ExamDate = (row.FindControl("mastercode") as TextBox).Text;
        if ((row.FindControl("examtime") as TextBox).Text != "")
            ecourse.ExamTime = (row.FindControl("examtime") as TextBox).Text.ToString();
        ecourse.Id =Convert.ToInt32( (row.FindControl("lblID") as Label).Text);
        int result = ecourse.updateECourse();
            if (result == 1)
            {
                lblMessage.ForeColor = System.Drawing.Color.Blue;
                lblMessage.Text = "درس براي ارائه با موفقيت ويرايش شد.";
                imSuccess.ImageUrl = "../../../images/succes.GIF";
                imSuccess.Visible = true;
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
                imSuccess.ImageUrl = "../../../images/error.gif";
                imSuccess.Visible = true;
                return;
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
