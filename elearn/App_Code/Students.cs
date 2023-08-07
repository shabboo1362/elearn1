using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Dottext.Framework.Data;

/// <summary>
/// Summary description for Students
/// </summary>
public class Students
{
     #region Members
    private string  CodeStudent;//کد  کاربری
    private string  Name;//  نام
    private string  Family;// نام خانوادگی
    private string  Father;//نام پدر
    private string  CodeMelli;// کد ملی
    private string  ShShenasNameh;// شماره شناسنامه
    private string  Tarikh_t;// آخرین مدرک تحصیل
    private string  CodeReshte;// کد رشته تحصیلی
    private string  Tel;// تلفن
    private string  Address;//آدرس
    private string  CodeDore;//نوع کاربر

    private string  connectionString;
    #endregion
    #region Properties
    public string codeStudent
    {
        get { return CodeStudent; }
        set { CodeStudent = value; }
    }
     public string name
    {
        get { return Name; }
        set { Name = value; }
    }
     public string family
    {
        get { return Family; }
        set { Family = value; }
    }
     public string father
    {
        get { return Father; }
        set {Father = value; }
    }
     public string codeMelli
    {
        get { return CodeMelli; }
        set { CodeMelli = value; }
    }
     public string shShenasNameh
    {
        get { return ShShenasNameh; }
        set { ShShenasNameh = value; }
    }
     public string tarikh_t
    {
        get { return Tarikh_t; }
        set { Tarikh_t = value; }
     }
      public string codeReshte
    {
        get { return CodeReshte; }
        set { CodeReshte = value; }
     }
      public string tel
    {
        get { return Tel; }
        set { Tel = value; }
     }
      public string address
    {
        get { return Address; }
        set { Address = value; }
    }
     public string codeDore
    {
        get { return CodeDore; }
        set { CodeDore = value; }
    }
     
    #endregion
    public Students()
	{
         
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
    public int newStudent()
   {
       int success = 0;
        if (CodeStudent!="" && Name!="" && Family!="" && Father!="" && CodeMelli!="" && ShShenasNameh!=""  && Address!="" && Tarikh_t!=""  && CodeDore!="" && CodeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newStudent";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@CodeStudent", CodeStudent);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@Family", Family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@Father", Father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@CodeMelli", CodeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@Address", Address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@ShShenasNameh", ShShenasNameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@Tel", Tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@Tarhkh_t", Tarikh_t);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;

                SqlParameter param12 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@CodeReshte", CodeReshte);
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
   public int updateStudent()
   {
     int success = 0;
        if (CodeStudent!="" && Name!="" && Family!="" && Father!="" && CodeMelli!="" && ShShenasNameh!="" && Address!="" && Tarikh_t!=""  && CodeDore!="" && CodeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateStudent";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@CodeStudent", CodeStudent);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@Family", Family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@Father", Father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@CodeMelli", CodeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@Address", Address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@ShShenasNameh", ShShenasNameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@Tel", Tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@Tarhkh_t", Tarikh_t);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;

                SqlParameter param12 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@CodeReshte", CodeReshte);
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
   public int strictUpdateStudent ()
   {
        int success = 0;
        if (CodeStudent!="" && Name!="" && Family!="" && Father!="" && CodeMelli!="" && ShShenasNameh!="" && Address!="" && Tarikh_t!=""  && CodeDore!="" && CodeReshte!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "strictUpdateStudent";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@CodeStudent", CodeStudent);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Name", Name);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@Family", Family);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@Father", Father);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@CodeMelli", CodeMelli);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param6 = command.Parameters.AddWithValue("@Address", Address);
                param6.DbType = DbType.String;
                param6.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@ShShenasNameh", ShShenasNameh);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@Tel", Tel);
                param9.DbType = DbType.String;
                param9.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@Tarhkh_t", Tarikh_t);
                param10.DbType = DbType.String;
                param10.Direction = ParameterDirection.Input;


                SqlParameter param12 = command.Parameters.AddWithValue("@CodeDore", CodeDore);
                param12.DbType = DbType.String;
                param12.Direction = ParameterDirection.Input;

                SqlParameter param13 = command.Parameters.AddWithValue("@CodeReshte", CodeReshte);
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
   
   public int deleteStudent ()
   {    
	 int success = -3;
    if (CodeStudent!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteStudent";
                command.CommandType = CommandType.StoredProcedure;

                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorStat", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@CodeStudent", CodeStudent);
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
   public DataTable allStudent ()
   {
        SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allStudent");
               
           }
           finally
           {
               connection.Close();
           }
       return dt;
   }
public int  StudentInfo ()
   {
       int success = -1;
       if (CodeStudent != "")
       {
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@CodeStudent", SqlDbType.NVarChar, 20);
               parameters[0].Value = CodeStudent;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "StudentInfo", parameters);
               if (dt.Rows.Count == 0)
               {
                   success = -1;
                   return success;
               }
               object[] obj = dt.Rows[0].ItemArray;
               CodeStudent = obj[0].ToString();
               Name = obj[1].ToString();
               Family = obj[2].ToString();
               Father = obj[3].ToString();
               CodeMelli = obj[4].ToString();
               ShShenasNameh = obj[5].ToString();
               Tarikh_t = obj[6].ToString();
               CodeReshte = obj[7].ToString();
               Tel = obj[8].ToString();
               Address = obj[8].ToString();
               CodeDore = obj[10].ToString();
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
