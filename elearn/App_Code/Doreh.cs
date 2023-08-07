using System;
using System.Data;
using System.Data.SqlTypes;
using Dottext.Framework.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Doreh
/// </summary>
public class Doreh
{
    #region Members
    private string CodeDore;
    private int Year;
    private byte Term;
    private byte status;
    private string connectionString;
    #endregion
    #region Properties
    public int YEar
    {
        get { return Year; }
        set { Year = value; }
    }
    public string COdeDore
    {
        get { return CodeDore; }
        set { CodeDore = value; }
    }
    public byte TErm
    {
        get { return Term; }
        set { Term = value; }
    }
    public byte Status
    {
        get { return status ; }
        set { status = value; }
    }
    #endregion
	public Doreh()
	{
        CodeDore = "";
        Term = 0;
        status = 0;
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
	}
    #region method
       public int newDoreh ()
   {
           int success = -1;
           if (CodeDore != "" && Year > 0)
           {
               SqlConnection connenction = new SqlConnection(connectionString);
               try
               {
                   connenction.Open();
                   SqlCommand command = new SqlCommand();

                   command.Connection = connenction;
                   command.CommandText = "newDoreh";
                   command.CommandType = CommandType.StoredProcedure;

                   SqlParameter param1 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                   param1.DbType = DbType.String;
                   param1.Direction = ParameterDirection.Input;

                   SqlParameter param4 = command.Parameters.AddWithValue("@Term", Term);
                   param4.DbType = DbType.Byte;
                   param4.Direction = ParameterDirection.Input;

                   SqlParameter param5 = command.Parameters.AddWithValue("@Year", Year);
                   param5.DbType = DbType.Int16;
                   param5.Direction = ParameterDirection.Input;

                   SqlParameter param6 = command.Parameters.AddWithValue("@status", status );
                   param6.DbType = DbType.Int16;
                   param6.Direction = ParameterDirection.Input;

                   int error = -2;
                   SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                   param8.DbType = DbType.Int32;
                   param8.Direction = ParameterDirection.InputOutput;

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
   public int updateDoreh()
   { 
       int success = -1;
        if (CodeDore!=""  && Year>0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateDoreh";
                command.CommandType = CommandType.StoredProcedure;
                 SqlParameter param1 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@Term", Term);
                param4.DbType = DbType.Byte;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@Year", Year);
                param5.DbType = DbType.Int16;
                param5.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

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
   public int strictUpdateDoreh ()
   {
        int success = -1;
        if (CodeDore!=""  && Year>0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = " strictUpdateDoreh";
                command.CommandType = CommandType.StoredProcedure;
                 SqlParameter param1 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param4 = command.Parameters.AddWithValue("@Term", Term);
                param4.DbType = DbType.Byte;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@Year", Year);
                param5.DbType = DbType.Int16;
                param5.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

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
   public int deleteDoreh ()
   {  
       int success = -3;
    if (CodeDore!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteDoreh";
                command.CommandType = CommandType.StoredProcedure;

                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorSta", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

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

   public DataTable allDoreh ()
   {
       
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allDoreh");
               
           }
           finally
           {
               connection.Close();
           }
       return dt;
   }

public int  DorehInfo ()
   {
       int success = -1;
       if (CodeDore!="")
       {
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@CodeDore", SqlDbType.NVarChar, 20);
               parameters[0].Value = CodeDore;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "DorehInfo", parameters);
               if (dt.Rows.Count == 0)
               {
                   success = -1;
                   return success;
               }
               object[] obj = dt.Rows[0].ItemArray;
               CodeDore = obj[0].ToString();
               Year =int.Parse(obj[1].ToString());
               Term =byte.Parse(obj[2].ToString());
           }
           finally
           {
               connection.Close();
           }
       }
       return success;
   }

    public int dorehJari()
    {
        int success = -1;
        
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "dorehJari");
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray;
                CodeDore = obj[0].ToString();
                Year = int.Parse(obj[1].ToString());
                Term = byte.Parse(obj[2].ToString());
                success = 1;
            }
            finally
            {
                connection.Close();
            }
        
        return success;
    }
#endregion


}
