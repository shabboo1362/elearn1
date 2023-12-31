using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Setting
/// </summary>
public class Setting
{
    private string connectionString; 
	public Setting()
	{
        connectionString = ConfigurationManager.ConnectionStrings["connectionString1"].ConnectionString;
    }
    #region Methods
    public static string CurentDate()
    {
        string curDate = "";
        DateTime dtime = DateTime.Now;
        PersianCalendar pc = new PersianCalendar();
        int year = pc.GetYear(dtime);
        int month = pc.GetMonth(dtime);
        int day = pc.GetDayOfMonth(dtime);
        curDate = "" + pc.GetYear(dtime) + "/";
        if (month < 10)
            curDate += "0" + month + "/";
        else
            curDate += month + "/";
        if (day < 10)
            curDate += "0" + day;
        else
            curDate += day;
        return curDate;
    }
    public static int CurentYearMonth()
    {
        DateTime dtime = DateTime.Now;
        PersianCalendar pc = new PersianCalendar();
        return pc.GetYear(dtime);
    }
    public static string OneMonthLater()
    {
        string curDate = "";
        DateTime dtime = DateTime.Now.AddMonths(1);
        PersianCalendar pc = new PersianCalendar();
        int year = pc.GetYear(dtime);
        int month = pc.GetMonth(dtime);
        int day = pc.GetDayOfMonth(dtime);
        curDate = "" + pc.GetYear(dtime) + "/";
        if (month < 10)
            curDate += "0" + month + "/";
        else
            curDate += month + "/";
        if (day < 10)
            curDate += "0" + day;
        else
            curDate += day;
        return curDate;
    }
    public static string OneYearLater()
    {
        string curDate = "";
        DateTime dtime = DateTime.Now.AddYears(1);
        PersianCalendar pc = new PersianCalendar();
        int year = pc.GetYear(dtime);
        int month = pc.GetMonth(dtime);
        int day = pc.GetDayOfMonth(dtime);
        curDate = "" + pc.GetYear(dtime) + "/";
        if (month < 10)
            curDate += "0" + month + "/";
        else
            curDate += month + "/";
        if (day < 10)
            curDate += "0" + day;
        else
            curDate += day;
        return curDate;
    }
    public string CurentMonthName()
    {
            string name = new string(' ', 100);
            
            SqlConnection connenction = new SqlConnection(connectionString);
            
            SqlCommand command = new SqlCommand();
            try
            {
                connenction.Open();
                command.Connection = connenction;
                command.CommandText = "storManager";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param25 = command.Parameters.AddWithValue("@name", name );
                param25.DbType = DbType.String;
                param25.Direction = ParameterDirection.InputOutput;
                command.ExecuteNonQuery();
                name = "" + command.Parameters["@name"].Value;
            }
            finally
            {
                connenction.Close();
            }
            return name ;
    }
    public int    CurentMonthNameUpdate(string name)
    {
        SqlConnection connenction = new SqlConnection(connectionString);
        int error = -1;
        SqlCommand command = new SqlCommand();
        try
        {
            connenction.Open();
            command.Connection = connenction;
            command.CommandText = "storManagerUpdate";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param25 = command.Parameters.AddWithValue("@name", name);
            param25.DbType = DbType.String;
            param25.Direction = ParameterDirection.Input;

            
            SqlParameter param26 = command.Parameters.AddWithValue("@error", error );
            param26.DbType = DbType.String;
            param26.Direction = ParameterDirection.InputOutput;

            command.ExecuteNonQuery();
            error = Convert.ToInt32("" + command.Parameters["@error"].Value);
        }
        finally
        {
            connenction.Close();
        }
        return error ;
    }
    public static string filter(string inputStr)
    {
        string tmp = inputStr;
        tmp = tmp.Replace("'", "");
        tmp = tmp.Replace("--", "");
        tmp = tmp.Replace("      ", " ");
        tmp = tmp.Replace("     ", " ");
        tmp = tmp.Replace("    ", " ");
        tmp = tmp.Replace("   ", " ");
        tmp = tmp.Replace("  ", " ");
        return tmp;
    }
    #endregion
}
