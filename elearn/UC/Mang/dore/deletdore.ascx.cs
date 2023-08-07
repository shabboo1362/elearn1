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
            lblMessage.Text = "��� �� ��� ���� " + dore.COdeDore + " ������� ����� ";
        
        }
        else
        {
            btnDel.Visible = false;
            Button1.Text = "��Ґ�� �� ���� ������";
        }
    }
    protected void btnDel_Click(object sender, EventArgs e)
    {
        int result = dore.deleteDoreh();
        if (result == -2)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "��� �� ����� ����";
        }
        else if (result == 1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "���� ������� �� ������ ��� ����� ";
        }
        else if (result == -1)
        {
            imSuccess.Visible = true;
            imSuccess.ImageUrl = "../../../images/error.gif";
            lblMessage.Text = "��� �� ���� ���� ����� �� ����� ��� ��� ";
        }
        btnDel.Visible = false;
        Button1.Text = "��Ґ�� �� ���� ������";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./manag.aspx");
    }
}
