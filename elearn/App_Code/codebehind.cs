using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using farhaniPersianDate;

/// <summary>
/// Summary description for codebehind
/// </summary>
public class codebehind
{
    public string StrCon = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString.ToString();
    DataTable Dt = new DataTable();
    SqlDataAdapter Adapter = new SqlDataAdapter();
    cDate PersianDate = new cDate();
    public  SqlConnection MyCon;
	public codebehind()
	{
		
	}
    public bool AddNews(string title, string description, string priority, string activeDate, string expDate, string imageName)
    {
        SqlCommand command = new SqlCommand();
        MyCon = new SqlConnection(StrCon);
        bool Inserted = false;
        int ViewCount = 0;
        PersianDate.displyFormat = "dd;/mm;/yy;";
        string perdate = PersianDate.getPersianDate(DateTime.Now.Date).ToString();
        command.CommandText = "AddNews";
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@description", description);
        command.Parameters.AddWithValue("@priority", priority);
        command.Parameters.AddWithValue("@imageName", imageName);
        command.Parameters.AddWithValue("@activeDate", activeDate);
        command.Parameters.AddWithValue("@expDate", expDate);
        command.Connection = MyCon;
        MyCon.Open();
        command.ExecuteNonQuery();
        Inserted = true;
        MyCon.Close();
        return Inserted;
    }
    
}
