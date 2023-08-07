using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using Dottext.Framework.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for RegisterTiming
/// </summary>
public class RegisterTiming
{
	#region Members
    private string  dorehCode;//کد دوره ای که می خواهیم زمانبندی کنیم
    private string  inputDorehCode;//کد دوره وردی دانشجویان
    private string  regBeginDate;
    private string  regExpDate;
    private string  addRemBeginDate;
    private string  addRemExpDate;
    private string  emgRemBeginDate;
    private string  emgRemExpDate;

    private string  connectionString;
    #endregion
    #region Properties
	public string DorehCode
    {
        get { return dorehCode; }
        set { dorehCode = value; }
    }
     public string InputDorehCode
    {
        get { return inputDorehCode; }
        set { inputDorehCode = value; }
    }
     public string RegBeginDate
    {
        get { return regBeginDate; }
        set { regBeginDate = value; }
    }
     public string RegExpDate
    {
        get { return regExpDate; }
        set { regExpDate = value; }
    }
     public string AddRemBeginDate
    {
        get { return addRemBeginDate; }
        set { addRemBeginDate = value; }
    }
     public string AddRemExpDate
    {
        get { return addRemExpDate; }
        set { addRemExpDate = value; }
    }
     public string EmgRemBeginDate
    {
        get { return emgRemBeginDate; }
        set { emgRemBeginDate = value; }
     }
      public string EmgRemExpDate
    {
        get { return emgRemExpDate; }
        set { emgRemExpDate = value; }
     }
    #endregion
    public RegisterTiming ()
	{
         
    connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods

   public int newRegTiming ()
   {
    int success = 0;
        if (dorehCode!="" && inputDorehCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newRegTiming";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@dorehCode", dorehCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@inputDorehCode", inputDorehCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@regBeginDate", regBeginDate);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@regExpDate", regExpDate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@addRemBeginDate", addRemBeginDate);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@addRemExpDate", addRemExpDate);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@emgRemBeginDate", emgRemBeginDate);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@emgRemExpDate", emgRemExpDate);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

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
   public int deleteRegTiming()
   {
		int success = -3;
        if (dorehCode!="" && inputDorehCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteRegTiming";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param2 = command.Parameters.AddWithValue("@errorStat", error);
                param2.DbType = DbType.Int32;
                param2.Direction = ParameterDirection.InputOutput;

                SqlParameter param1 = command.Parameters.AddWithValue("@dorehCode",dorehCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@inputDorehCode",inputDorehCode);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

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
   public int updateRegTiming ()
   {
	 	int success = 0;
        if (dorehCode!="" && inputDorehCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateRegTiming";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@dorehCode", dorehCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@inputDorehCode", inputDorehCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@regBeginDate", regBeginDate);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@regExpDate", regExpDate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@addRemBeginDate", addRemBeginDate);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@addRemExpDate", addRemExpDate);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@emgRemBeginDate", emgRemBeginDate);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@emgRemExpDate", emgRemExpDate);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

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
   public int inputRegTimingInfo ()
   {
	 int success = 0;
        if (dorehCode!="" && inputDorehCode!="")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@dorehCode", SqlDbType.NVarChar , 20);
                parameters[0].Value = dorehCode;

                parameters[1] = new SqlParameter("@inputDorehCode", SqlDbType.NVarChar , 20);
                parameters[1].Value = inputDorehCode;
                
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "inputRegTimingInfo" ,parameters );
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray ;
                dorehCode = obj[0].ToString();
                inputDorehCode = obj[1].ToString();
                regBeginDate  = obj[2].ToString();
                regExpDate  = obj[3].ToString();
                addRemBeginDate  = obj[4].ToString();
                addRemExpDate = obj[5].ToString();
                emgRemBeginDate = obj[6].ToString();
                emgRemExpDate=obj[7].ToString();
            }
            finally
            {
                connection.Close();
            }
        }
        return success;	        
   }
   public DataTable allRegTiming ()
   {

       SqlConnection connection = new SqlConnection(connectionString);
       DataTable dt = new DataTable();
       try
       {
           SqlParameter[] parameters = new SqlParameter[1];

           parameters[0] = new SqlParameter("@dorehCode", SqlDbType.NVarChar, 20);
           parameters[0].Value = dorehCode;

           dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allRegTiming", parameters);

       }
       finally
       {
           connection.Close();
       }
       return dt;

   }
    #endregion
}
