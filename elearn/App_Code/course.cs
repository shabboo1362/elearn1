using System;
using System.Data;
using System.Configuration;
using System.Web;
using Dottext.Framework.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for course
/// </summary>

	public class Course
{
     #region Members
    private string  courseCode;
    private string  courseName;
    private string  codeReshte;
    private string  courseType;
    private float   nUnit;// واحد نظری
    private float   aUnit;//واحد عملی
    private float	  passGread ;
    private string  filedName;
    private string  connectionString;
    #endregion
    #region Properties
    public float NUnit
    {
        get { return nUnit; }
        set { nUnit = value; }
    }
    public string CourseCode
    {
        get { return courseCode; }
        set { courseCode = value; }
    }
    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }
    public string CodeReshte
    {
        get { return codeReshte; }
        set { codeReshte  = value; }
    }
    public float AUnit
    {
        get { return aUnit ; }
        set { aUnit  = value; }
    }
    public float PassGread
    {
        get { return passGread; }
        set { passGread = value; }
    }
     public string CourseType
    {
        get { return courseType; }
        set { courseType  = value; }
    }
     public string FiledName
    {
        get { return filedName; }
        set { filedName  = value; }
    }
    #endregion
    public Course ()
	{
        courseType = "";
        nUnit=3;
        aUnit=0;
        passGread=10;
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
    }
    #region Methods

   public int newCourse ()
   {
        int success = 0;
        if (courseCode!="" && courseName!="" && courseType!="" && (aUnit!=0 || nUnit!=0))
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newcourse";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@courseName", courseName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@courseType", courseType);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@nUnit", nUnit);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@aUnit", aUnit);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@passGread", passGread);
                param9.DbType = DbType.Double;
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
   public int updateCourse()
   {
       
        int success = -1;
        if (courseCode!="" && courseName!="" && (aUnit!=0 || nUnit!=0))
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updatecourse";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = command.Parameters.AddWithValue("@courseName", courseName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@courseType", courseType);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@nUnit", nUnit);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@aUnit", aUnit);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@passGread", passGread);
                param9.DbType = DbType.Double;
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

   public int strictUpdateCourse()
   {

	
        int success = -1;
        if (courseCode!="" && courseName!="" && (aUnit!=0 || nUnit!=0)&& courseType!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = " strictupdatecourse";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = command.Parameters.AddWithValue("@courseName", courseName);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@codeReshte", codeReshte);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@courseType", courseType);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.InputOutput;

                SqlParameter param7 = command.Parameters.AddWithValue("@nUnit", nUnit);
                param7.DbType = DbType.Double;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@aUnit", aUnit);
                param10.DbType = DbType.Double;
                param10.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@passGread", passGread);
                param9.DbType = DbType.Double;
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

   public int deleteCourse()
   {
	int success = -3;
        if ( courseCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deletecourse";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param5 = command.Parameters.AddWithValue("@errorStat", error);
                param5.DbType = DbType.Int32;
                param5.Direction = ParameterDirection.InputOutput;

                SqlParameter param6 = command.Parameters.AddWithValue("@courseCode",courseCode);
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
    public DataTable allCourseIdName()
   {
       DataTable dt= new DataTable();
       if ( courseCode!="")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "allCourseIdName";
                SqlParameter param1 = command.Parameters.AddWithValue("@codeReshteh",codeReshte);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCourseIdName");
                
           }
           finally
            {
                connection.Close();
            }
       }
       return dt;
   }
   public DataTable allCourse ()
   {
      
           SqlConnection connection = new SqlConnection(connectionString);
           DataTable dt = new DataTable();
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@codeReshte", SqlDbType.NVarChar, 20);
               parameters[0].Value = codeReshte;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCourse", parameters);
               
           }
           finally
           {
               connection.Close();
           }
       return dt;

   }
   public int  courseInfo ()
   {
	int success = -1;
        if (courseCode!="")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@courseCode", SqlDbType.NVarChar , 20);
                parameters[0].Value = courseCode;
                
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "courseInfo" ,parameters );
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray ;
                courseCode = obj[0].ToString();
                courseName  = obj[1].ToString();
                CodeReshte  = obj[2].ToString();
                courseType  = obj[3].ToString();
                nUnit = float.Parse(obj[4].ToString());
                aUnit = float.Parse(obj[5].ToString());
                passGread=float.Parse(obj[6].ToString());
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
