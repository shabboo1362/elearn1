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
/// Summary description for Master
/// </summary>
public class Master
{
   #region Members
    private string  userCode;//کد  کاربری
    private string  name;//  نام
    private string  family;// نام خانوادگی
    private string  father;//نام پدر
    private string  codeMelli;// کد ملی
    private string  shShenasnameh;// شماره شناسنامه
    private string  lastGrade;// آخرین مدرک تحصیلی
    private string  reshte;//رشته تحصیلی
    private string  codeReshte;// کد رشته تحصیلی
    private string  tel;// تلفن
    private string  address;//آدرس
    private string  typeUser;//نوع کاربر

    private string  connectionString;
    #endregion
    #region Properties
	 public string UserCode
    {
        get { return userCode; }
        set { userCode = value; }
    }
     public string Name
    {
        get { return name; }
        set { name = value; }
    }
     public string Family
    {
        get { return family; }
        set { family = value; }
    }
     public string Father
    {
        get { return father; }
        set { father = value; }
    }
     public string CodeMelli
    {
        get { return codeMelli; }
        set { codeMelli = value; }
    }
     public string ShShenasnameh
    {
        get { return shShenasnameh; }
        set { shShenasnameh = value; }
    }
     public string LastGrade
    {
        get { return lastGrade; }
        set { lastGrade = value; }
     }
      public string Reshte
    {
        get { return reshte; }
        set { reshte = value; }
     }
      public string CodeReshte
    {
        get { return codeReshte; }
        set { codeReshte = value; }
     }
      public string Tel
    {
        get { return tel; }
        set { tel = value; }
     }
      public string Address
    {
        get { return address; }
        set { address = value; }
    }
     public string TypeUser
    {
        get { return typeUser; }
        set { typeUser = value; }
    }
     
    #endregion
    public Master()
	{
         
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
   public int newMaster ()
   {
       int success = 0;
        if (userCode!="" && codeMelli!="" )
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newMaster";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@userCode", userCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@name", name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@family", family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@father", father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@codeMelli", codeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@address", address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@shShenasnameh", shShenasnameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@tel", tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@typeUser", typeUser);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;


                SqlParameter param12 = command.Parameters.AddWithValue("@reshte", reshte);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param13.DbType = DbType.String;
                param13.Direction = ParameterDirection.Input;

                SqlParameter param14 = command.Parameters.AddWithValue("@lastGrade", lastGrade );
                param14.DbType = DbType.String;
                param14.Direction = ParameterDirection.Input;

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
   public int updateMaster()
   {
     int success = 0;
        if (userCode!="" && name!="" && family!="" && father!="" && codeMelli!="" 
            && shShenasnameh!="" && address!="" && lastGrade!="" && reshte!="" && codeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateMaster";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@userCode", userCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@name", name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@family", family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@father", father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@codeMelli", codeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@address", address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@shShenasnameh", shShenasnameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@tel", tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@typeUser", typeUser);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;

                SqlParameter param11 = command.Parameters.AddWithValue("@lastGrade", lastGrade);
                param11.DbType = DbType.String;
                param11.Direction = ParameterDirection.Input;

                SqlParameter param12 = command.Parameters.AddWithValue("@reshte", reshte);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param13.DbType = DbType.String;
                param13.Direction = ParameterDirection.Input;

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
   public int strictUpdateMaster ()
   {
        int success = 0;
        if (userCode!="" && name!="" && family!="" && father!="" && codeMelli!="" && shShenasnameh!="" && address!="" && typeUser!="" && lastGrade!="" && reshte!="" && codeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "strictUpdateMaster";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@userCode", userCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@name", name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@family", family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@father", father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@codeMelli", codeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@address", address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@shShenasnameh", shShenasnameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@tel", tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@typeUser", typeUser);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;

                SqlParameter param11 = command.Parameters.AddWithValue("@lastGrade", lastGrade);
                param11.DbType = DbType.String;
                param11.Direction = ParameterDirection.Input;

                SqlParameter param12 = command.Parameters.AddWithValue("@reshte", reshte);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param13.DbType = DbType.String;
                param13.Direction = ParameterDirection.Input;

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
   
   public int deleteMaster ()
   {    
	 int success = -3;
    if (userCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteMaster";
                command.CommandType = CommandType.StoredProcedure;

                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorStat", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@userCode", userCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

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
   public DataTable allMaster ()
   {
        SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               int error = -2;
               SqlParameter[] parameters = new SqlParameter[1];
               parameters[0] = new SqlParameter("@errorStat", SqlDbType.Int,32);
               parameters[0].Value = error;
               parameters[0].Direction = ParameterDirection.InputOutput;
               

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allMaster",parameters);
               
           }
           finally
           {
               connection.Close();
           }
       return dt;
   }
public int  MasterInfo ()
   {
       int success = -1;
       if (userCode != "")
       {
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@userCode", SqlDbType.NVarChar, 20);
               parameters[0].Value = userCode;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "MasterInfo", parameters);
               if (dt.Rows.Count == 0)
               {
                   success = -1;
                   return success;
               }
               object[] obj = dt.Rows[0].ItemArray;
               userCode = obj[0].ToString();
               name = obj[1].ToString();
               family = obj[2].ToString();
               father = obj[3].ToString();
               codeMelli = obj[4].ToString();
               shShenasnameh = obj[5].ToString();
               lastGrade = obj[6].ToString();
               reshte = obj[7].ToString();
               codeReshte = obj[8].ToString();
               tel = obj[9].ToString();
               address = obj[10].ToString();
               typeUser = obj[11].ToString();
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
