using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dottext.Framework.Data;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Maghtaa
/// </summary>
public class Maghtaa
{
#region Members
    private string  NameMaghtaa;//نام مقطع
    private float  MinVahed;// حداقل واحد قابل اخذ
    private float  MoadelA;//َA  معدل
    private float  MoadelMashrooti;//معدل مشروطی
    private float  MaxVmashrooti;// حداکثر واحد قابل اخذ در حالت مشروطی
    private float  MaxVahedA;// حداکثر واحد قابل اخذ در حالت معدل الف
    private float  MaxVahedG;// حداکثر واحد قابل اخذ در حالت عادی

    private string  connectionString;
    #endregion
    #region Properties
	 public string nameMaghtaa
    {
        get { return NameMaghtaa; }
        set { NameMaghtaa  = value; }
    }
    public float minVahed
    {
        get { return MinVahed ; }
        set { MinVahed  = value; }
    }
    public float moadelA
    {
        get { return MoadelA ; }
        set { MoadelA  = value; }
    }
    public float moadelMashrooti
    {
        get { return MoadelMashrooti ; }
        set { MoadelMashrooti  = value; }
    }
    public float maxVmashrooti
    {
        get { return MaxVmashrooti ; }
        set { MaxVmashrooti  = value; }
    }
    public float maxVahedA
    {
        get { return MaxVahedA ; }
        set { MaxVahedA  = value; }
    }
    public float maxVahedG
    {
        get { return MaxVahedG ; }
        set { MaxVahedG  = value; }
    }
    #endregion
    public Maghtaa()
	{
        MinVahed =8;
        MoadelA=17;
        MoadelMashrooti=12;
        maxVmashrooti=14;
        maxVahedA=24;
        maxVahedG=20;
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
   public int newMaghtaa ()
   {
       int success = 0;
        if (NameMaghtaa!=""&& MinVahed<maxVmashrooti && maxVmashrooti<maxVahedG && maxVahedG<maxVahedA)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newMaghtaa";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@MinVahed",MinVahed);
                param2.DbType = DbType.Decimal;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@maxVmashrooti", maxVmashrooti);
                param3.DbType = DbType.Decimal;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@maxVahedG", maxVahedG);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@maxVahedA", maxVahedA);
                param5.DbType = DbType.Decimal;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@MoadelMashrooti", MoadelMashrooti);
                param6.DbType = DbType.Decimal;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@MoadelA", MoadelA);
                param7.DbType = DbType.Decimal;
                param7.Direction = ParameterDirection.Input;

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
   public int updateMaghtaa ()
   {

	 int success = 0;
        if (NameMaghtaa!=""&& MinVahed<maxVmashrooti && maxVmashrooti<maxVahedG && maxVahedG<maxVahedA)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateMaghtaa";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@MinVahed",MinVahed);
                param2.DbType = DbType.Decimal;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@maxVmashrooti", maxVmashrooti);
                param3.DbType = DbType.Decimal;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@maxVahedG", maxVahedG);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@maxVahedA", maxVahedA);
                param5.DbType = DbType.Decimal;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@MoadelMashrooti", MoadelMashrooti);
                param6.DbType = DbType.Decimal;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@MoadelA", MoadelA);
                param7.DbType = DbType.Decimal;
                param7.Direction = ParameterDirection.Input;

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
   public int strictUpdateMaghtaa ()
   {
int success = 0;
        if (NameMaghtaa!=""&& MinVahed<maxVmashrooti && maxVmashrooti<maxVahedG && maxVahedG<maxVahedA)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "strictUpdateMaghtaa";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@NameMaghtaa", NameMaghtaa);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@MinVahed",MinVahed);
                param2.DbType = DbType.Decimal;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@maxVmashrooti", maxVmashrooti);
                param3.DbType = DbType.Decimal;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@maxVahedG", maxVahedG);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@maxVahedA", maxVahedA);
                param5.DbType = DbType.Decimal;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@MoadelMashrooti", MoadelMashrooti);
                param6.DbType = DbType.Decimal;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@MoadelA", MoadelA);
                param7.DbType = DbType.Decimal;
                param7.Direction = ParameterDirection.Input;

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

   public int deleteMaghtaa ()
   {	    
	int success = -3;
        if ( NameMaghtaa!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteMaghtaa";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param5 = command.Parameters.AddWithValue("@errorStat", error);
                param5.DbType = DbType.Int32;
                param5.Direction = ParameterDirection.InputOutput;

                SqlParameter param6 = command.Parameters.AddWithValue("@NameMaghtaa",NameMaghtaa);
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
   public DataTable allMaghtaa ()
   {
	
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allMaghtaa");
               
           }
           finally
           {
               connection.Close();
           }
       return dt;
   }
   public DataTable allNameMaghtaa ()
   { 
       DataTable dt= new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            
            try
            {
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allNameMaghtaa");
           }
           finally
            {
                connection.Close();
            }
       return dt;    
   }

public int  MaghtaaInfo ()
   {
       int success = -1;
       if (NameMaghtaa != "")
       {
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@NameMaghtaa", SqlDbType.NVarChar, 40);
               parameters[0].Value = NameMaghtaa;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "MaghtaaInfo", parameters);
               if (dt.Rows.Count == 0)
               {
                   success = -1;
                   return success;
               }
               object[] obj = dt.Rows[0].ItemArray;
               MinVahed =float.Parse(obj[1].ToString());
               MoadelMashrooti =float.Parse(obj[2].ToString());
               MoadelA =float.Parse( obj[3].ToString());
               MaxVmashrooti =float.Parse( obj[4].ToString());
               MaxVahedA = float.Parse(obj[5].ToString());
               MaxVahedG = float.Parse(obj[6].ToString());
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
