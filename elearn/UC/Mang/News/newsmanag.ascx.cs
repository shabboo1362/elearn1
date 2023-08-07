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

public partial class UC_Mang_News_newsmanag : System.Web.UI.UserControl
{
    NewsManager news = new NewsManager();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        //------------------------------------------    Call  DataBindToGrid Methods
        
        if(!Page.IsPostBack)//------------------------------------------    Page_PreRender execute after all Methods 
        DataBindToGrid();
    }

    private void DataBindToGrid()
    {
        DataTable dt = news.allnews();
        gvPageManag.DataSource = dt;
        gvPageManag.DataBind();
    }
    protected void search_Click(object sender, EventArgs e)
    {

        if (title.Text !="")
        {
            news.NewsName = title.Text;
            DataTable dt = news.searchnews();
            gvPageManag.DataSource = dt;
            gvPageManag.DataBind();
        }
        else
        {
            DataTable dt = news.search(spdp.PersianDateString, spdp1.PersianDateString, epdp.PersianDateString, epdp1.PersianDateString);
            gvPageManag.DataSource = dt;
            gvPageManag.DataBind();
        }
        
    }
    protected void spdp_TextChanged(object sender, EventArgs e)
    {
        
    }
}
