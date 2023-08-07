using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using Dottext.Framework.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Reshte
/// </summary>
public class Reshte
{
	#region Members
    private string  CodeReshte;
    private string  Name;
    private string  NameMaghtaa;
    private float  VahedOmoomi;//واحدهای عمومی
    private float  VahedTZ;// واحد تخصصی ضروری
    private float 	  VahedTE;//واحد تخصصی اختیاری
	
    private string  connectionString;
    #endregion
    #region Properties
	public string codeReshte
    {
        get { return CodeReshte; }
        set { CodeReshte = value; }
    }
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    public string nameMaghtaa
    {
        get { return NameMaghtaa; }
        set { NameMaghtaa = value; }
    }
    public float vahedOmoomi
    {
        get { return VahedOmoomi; }
        set { VahedOmoomi  = value; }
    }
    public float vahedTZ
    {
        get { return VahedTZ ; }
        set { VahedTZ  = value; }
    }
    public float vahedTE
    {
        get { return VahedTE; }
        set { VahedTE = value; }
    }
    
    #endregion
    public Reshte ()
	{

         CodeReshte = "";
         name="";
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
   public int newReshte ()
   {
       int success = -1;
        if (CodeReshte!="" && Name!="" && NameMaghtaa!="" && VahedTE!=0 && VahedTZ!=0 && VahedOmoomi!=0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newReshte";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@VahedOmoomi", VahedOmoomi);
                param5.DbType = DbType.Double;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@VahedTZ", VahedTZ);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@VahedTE", VahedTE);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

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
   public int updateReshte()
   {
        
       int success = -1;
        if (CodeReshte!="" && Name!="" && NameMaghtaa!="" && VahedTE!=0 && VahedTZ!=0 && VahedOmoomi!=0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateReshte";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@VahedOmoomi", VahedOmoomi);
                param5.DbType = DbType.Double;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@VahedTZ", VahedTZ);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@VahedTE", VahedTE);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

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
   public int strictUpdateReshte()
   {
       int success = -1;
        if (CodeReshte!="" && Name!="" && NameMaghtaa!="" && VahedTE!=0 && VahedTZ!=0 && VahedOmoomi!=0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "strictUpdateReshte";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@VahedOmoomi", VahedOmoomi);
                param5.DbType = DbType.Double;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@VahedTZ", VahedTZ);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@VahedTE", VahedTE);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

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
   public int deleteReshte()
   {
       int success = -3;
        if ( CodeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteReshte";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param5 = command.Parameters.AddWithValue("@errorStat", error);
                param5.DbType = DbType.Int32;
                param5.Direction = ParameterDirection.InputOutput;

                SqlParameter param6 = command.Parameters.AddWithValue("@codeReshte",codeReshte);
                param6.DbType = DbType.String;
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
   public DataTable allReshteName ()
   {
   
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allReshteName");
               
           }
           finally
           {
               connection.Close();
           }
       return dt;
   }
   public DataTable allCodeReshte ()
   {
       DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataReader datareader;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "allCodeReshte";
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCodeReshte");

       }
       finally
        {
            connection.Close();
        }
       return dt;
   }
   public int  ReshteInfo ()
   {
       int success = -1;
       if (codeReshte != "")
       {
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@codeReshte", SqlDbType.NVarChar, 20);
               parameters[0].Value = codeReshte;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "ReshteInfo", parameters);
               if (dt.Rows.Count == 0)
               {
                   success = -1;
                   return success;
               }
               object[] obj = dt.Rows[0].ItemArray;
               Name = obj[1].ToString();
               NameMaghtaa = obj[2].ToString();
               VahedOmoomi =float.Parse(obj[3].ToString());
               VahedTZ = float.Parse(obj[4].ToString());
               VahedTE = float.Parse(obj[5].ToString());
               success = 1;
           }
           finally
           {
               connection.Close();
           }
       }
       return success;
   }
#endregion

}
