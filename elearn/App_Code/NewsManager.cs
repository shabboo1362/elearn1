using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Dottext.Framework.Data;
using farhaniPersianDate;


/// <summary>
/// Summary description for NewsManager
/// </summary>
public class NewsManager
{
       //===================================================================================================
    //                      This Class is Interfase for Page Table in Data Base
    //                      Whit this Class all page inserted, updated , and Retrieve data
    //                      Tow Method of This Class For Retrieve Data and Update Data
    //
    //  
    //===================================================================================================
    #region Member
    private string  connectionString;
    private string  newsName;
    private string  context;
    private int     priority ;
    private int     visitedCount ;
    private int     newsId;
    private string  expdate;
    private string  imagename;
    private string  activedate;
    private int reshte;
    #endregion
    #region Properties
    public int NewsID
    {
        get { return newsId; }
        set { newsId = value; }
    }
    public string NewsName
    {
        get { return newsName; }
        set { newsName = value; }
    }
    public string Context
    {
        get { return context; }
        set { context = value; }
    }
    public string expDate
    {
        get { return expdate; }
        set { expdate  = value; }
    }
    public int Priority
    {
        get { return priority ; }
        set { priority  = value; }
    }
    public int Reshte
    {
        get { return reshte; }
        set { reshte = value; }
    }
    public int  VisitedCount
    {
        get { return visitedCount ; }
        set { visitedCount = value; }
    }
     public string activeDate
    {
        get { return activedate; }
        set { activedate  = value; }
    }
     public string imageName
    {
        get { return imagename; }
        set { imagename  = value; }
    }
    #endregion
    #region Methods
    //
    // Summary:
    //     need newsName that we want to  Retrieve it's Data 
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public DataTable topnews()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "top5news");

        }
        finally
        {

            connection.Close();
        }
        return dt;
    }


    public int newscheck()
    {
        if( priority>255 || priority<0){
            return 1;
                }
                return 2;
    }
    public int NewsContext()
    {
        int success = -1;
        context = new string(' ', 10000);
        if (newsName != null && newsName != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "NewsContex";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@newsName", newsName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@context", context);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.InputOutput;

                command.ExecuteNonQuery();
                context = "" + command.Parameters["@context"].Value;
                success = 1;
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //     need newsName that we want to  Update it's Data 
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsContextUpdate()
    {
        int success = -1;
        if (newsName != null && newsName != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newsContexUpdate";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@newsName", newsName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@context", context);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();
                success = 1;
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //     need id that we want to  Retrieve it's Data 
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsContextRead()
    {
        int success = -1;
        context = new string(' ', 10000);
        if (newsId >0 )
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@id", SqlDbType.Int , 32);
                parameters[0].Value = newsId  ;
                
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "newsContexRead" ,parameters );
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray ;
                newsName = obj[1].ToString();
                context  = obj[2].ToString();
                priority = int.Parse(obj[4].ToString());
                activeDate=obj[5].ToString();
                expDate = obj[6].ToString();
                imageName = obj[7].ToString();
            }
            finally
            {
                connection.Close();
            }
        }
        return success;
    }
    public DataTable newsRead(string adate, string edate)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        SqlParameter[] parameters = new SqlParameter[3];

        parameters[0] = new SqlParameter("@reshte", SqlDbType.Int, 32);
        parameters[0].Value = reshte;
        parameters[1] = new SqlParameter("@adate", SqlDbType.NVarChar, 10);
        parameters[1].Value = adate;
        parameters[1] = new SqlParameter("@edate", SqlDbType.NVarChar, 10);
        parameters[1].Value = edate;
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "newsForManag");

        }
        finally
        {

            connection.Close();
        }
        return dt;
    }
    //newsRead
    // Summary:
    //     Return DataTable Of All Typic To show in Top Menu 
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    //public DataTable  pageContextMenu()
    //{
    //    DataTable dt = new DataTable();
    //    if (lang  != null && lang  != "")
    //    {
    //        SqlConnection connection = new SqlConnection(connectionString);
    //        try
    //        {
    //            SqlParameter[] parameters = new SqlParameter[1];

    //            parameters[0] = new SqlParameter("@lang", SqlDbType.NVarChar, 2);
    //            parameters[0].Value = lang ;

    //            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "PageContextMenu", parameters);
                
    //        }
    //        finally
    //        {
    //            connection.Close();
    //        }
    //    }
    //    return dt ;
    //}
    //
    // Summary:
    //      This methods Used To Create New Row In Page Table.
    //      need newsName And need context  
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsContextWrite()
    {
        int success = -1;
        if (newsName != null && newsName != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newsContexWrite";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@newsName", newsName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@context", context);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@activedate", activedate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@expdate", expdate);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@imagename", imagename);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@priority", priority);
                param7.DbType = DbType.Int32;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@reshte", reshte);
                param10.DbType = DbType.Int32;
                param10.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@id", newsId);
                param9.DbType = DbType.Int32;
                param9.Direction = ParameterDirection.InputOutput;

                command.ExecuteNonQuery();
                success = Convert.ToInt32(command.Parameters["@errorSta"].Value);
                if (success == 1)
                {
                    newsId = Convert.ToInt32(command.Parameters["@id"].Value);
                }
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //      This methods Used To Update New Row In Page Table.
    //      need newsName And need context  
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsContextReWrite()
    {
        int success = -3;
        if (newsName != null && newsName != "" && newsId >0  )
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newsContexReWrite";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@newsName", newsName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@context", context);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@activedate", activedate);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@expdate", expdate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@imagename", imagename);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@priority", priority);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;

                int error = -4;
                SqlParameter param7 = command.Parameters.AddWithValue("@errorSta", error);
                param7.DbType = DbType.Int32;
                param7.Direction = ParameterDirection.InputOutput;

                SqlParameter param8 = command.Parameters.AddWithValue("@id", newsId);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();
                success = Convert.ToInt32(command.Parameters["@errorSta"].Value);
                
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //      This methods Used To Remove A Row In Page Table.
    //      need Id of Typic  
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsRemove()
    {
        int success = -3;
        if ( newsId > 0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newsRemove";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param5 = command.Parameters.AddWithValue("@errorStat", error);
                param5.DbType = DbType.Int32;
                param5.Direction = ParameterDirection.InputOutput;

                SqlParameter param6 = command.Parameters.AddWithValue("@id", newsId);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();
                success = Convert.ToInt32(command.Parameters["@errorStat"].Value);

            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //      This methods Used To Retrive Data Of All Page To Manag.
    //     
    //
    // Returns:
    //     The Data Table Of All Page
    //
    // Exceptions:
    //   Not Have Exception
    public DataTable allnews()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "newsForManag");

        }
        finally
        {

            connection.Close();
        }
        return dt;
    }
    //
    // Summary:
    //      This methods Used To Increase Visit Count Of Page.
    //      need Id of Typic  
    //     
    //
    // Returns:
    //     The number That Indicate Error(1 For no error).
    //
    // Exceptions:
    //   Not Have Exception
    public int newsVisit()
    {
        if (newsId > 0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newsVisit";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param6 = command.Parameters.AddWithValue("@id", newsId);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();

            }
            finally
            {
                connenction.Close();
            }
        }
        return 1;

    }
    public int updatenews()
    {
        int success = -1;
        if (newsName != null && newsName != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updatenews";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@newsName", newsName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@context", context);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@activeDate", activedate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@expDate", expdate);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@priority", priority);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param8 = command.Parameters.AddWithValue("@reshte", reshte);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param7 = command.Parameters.AddWithValue("@errorSta", error);
                param7.DbType = DbType.Int32;
                param7.Direction = ParameterDirection.InputOutput;

                SqlParameter param3 = command.Parameters.AddWithValue("@id", newsId);
                param3.DbType = DbType.Int32;
                param3.Direction = ParameterDirection.Input;

                command.ExecuteNonQuery();
                success = Convert.ToInt32(command.Parameters["@errorSta"].Value);
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;
    }
    //
    // Summary:
    //      This methods Used Retrive Data Table Of Page Statistic.
    //        
    //     
    //
    // Returns:
    //     The Data Table Of All Page and Statistic.
    //
    // Exceptions:
    //   Not Have Exception
    //public DataTable pageStatistic()
    //{
    //    SqlConnection connection = new SqlConnection(connectionString);
    //    DataTable dt = new DataTable();
    //    try
    //    {
    //        dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "pageStatistic");

    //    }
    //    finally
    //    {

    //        connection.Close();
    //    }
    //    return dt;
    //}
    public DataTable searchnews()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();
        SqlParameter[] parameters = new SqlParameter[1];

        parameters[0] = new SqlParameter("@title", SqlDbType.NVarChar, 40);
        parameters[0].Value = newsName;
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "searchnews",parameters);

        }
        finally
        {

            connection.Close();
        }
        return dt;
    }
    public DataTable search(string sdate,string sdate1,string edate,string edate1)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();
        //command.Connection = connection;
        //command.CommandText = "search";
        //command.CommandType = CommandType.StoredProcedure;
        if (sdate1 == "" && sdate!="")
            sdate1 = "99/99/9999";
        if (edate1 == "" && edate !="")
            edate1 = "99/99/9999";
        SqlParameter[] parameters = new SqlParameter[4];

        parameters[0] = new SqlParameter("@sdate", SqlDbType.NVarChar, 10);
        parameters[0].Value = sdate;

        parameters[1] = new SqlParameter("@sdate1", SqlDbType.NVarChar, 10);
        parameters[1].Value = sdate1;

        parameters[2] = new SqlParameter("@edate", SqlDbType.NVarChar, 10);
        parameters[2].Value = edate;

        parameters[3] = new SqlParameter("@edate1", SqlDbType.NVarChar, 10);
        parameters[3].Value = edate1;

        //SqlParameter param1 = command.Parameters.AddWithValue("@sdate", sdate);
        //param1.DbType = DbType.String;
        //param1.Direction = ParameterDirection.Input;

        //SqlParameter param2 = command.Parameters.AddWithValue("@sdate1", sdate1);
        //param2.DbType = DbType.String;
        //param2.Direction = ParameterDirection.Input;

        //SqlParameter param4 = command.Parameters.AddWithValue("@edate", edate);
        //param4.DbType = DbType.String;
        //param4.Direction = ParameterDirection.Input;

        //SqlParameter param5 = command.Parameters.AddWithValue("@edate", edate1);
        //param5.DbType = DbType.String;
        //param5.Direction = ParameterDirection.Input;
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "search", parameters);

        }
        finally
        {

            connection.Close();
        }
        return dt;
    }
    #endregion

	public NewsManager()
	{
        context = "";
        newsName = "";
        priority = 0;
        visitedCount = 0;
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
	}
}
