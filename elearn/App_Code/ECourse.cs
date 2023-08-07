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
/// Summary description for ECourse
/// </summary>
public class ECourse
{  
#region Members
    private int 		id ;
    private string  courseCode;
    private string  courseName;
    private string 	  Codedore ;
    private int 	  capacity ;
    private int 	  branche ;
    private string  examDate ;
    private string  examTime ;
    private string  masterCode ;
    private string  connectionString;
    #endregion
    #region Properties
	public int Id
    {
        get { return id; }
        set { id = value; }
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
    public string CodeDore
    {
        get { return Codedore; }
        set { Codedore  = value; }
    }
    public int Capacity
    {
        get { return capacity ; }
        set { capacity  = value; }
    }
    public int Branche
    {
        get { return branche; }
        set { branche = value; }
    }
     public string ExamDate
    {
        get { return examDate; }
        set { examDate  = value; }
    }
     public string ExamTime
    {
        get { return examTime; }
        set { examTime  = value; }
    }
     public string MasterCode
    {
        get { return masterCode; }
        set { masterCode  = value; }
    }
    #endregion
    public ECourse ()
	{
        capacity = 20;
        examDate = "";
        examTime = "";
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
   public int newECourse ()
   {
     int success = -1;
        if (courseCode!="" && CodeDore!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newECourse";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@Codedore", Codedore);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@capacity", capacity);
                param2.DbType = DbType.Int32;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@masterCode", masterCode);
                param3.DbType = DbType.String;
                param3.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@examDate", examDate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                SqlParameter param7 = command.Parameters.AddWithValue("@examTime", examTime);
                param7.DbType = DbType.String;
                param7.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                SqlParameter param9 = command.Parameters.AddWithValue("@id", id);
                param9.DbType = DbType.Int32;
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
   public int updateECourse()
   {
       
        int success = 0;
        if (courseCode!="" && CodeDore!="" && id > 0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateECourse";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = command.Parameters.AddWithValue("@Codedore", Codedore);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@masterCode", masterCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@examDate", examDate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;
                
                SqlParameter param6 = command.Parameters.AddWithValue("@id", id);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;


                SqlParameter param7 = command.Parameters.AddWithValue("@capacity", capacity);
                param7.DbType = DbType.Int32;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@examTime", examTime);
                param10.DbType = DbType.String;
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
   public int strictUpdateECourse()
   {
    int success = 0;
        if (courseCode!="" && CodeDore!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "strictUpdateECourse";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = command.Parameters.AddWithValue("@Codedore", Codedore);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@masterCode", masterCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@examDate", examDate);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;
                
                SqlParameter param6 = command.Parameters.AddWithValue("@id", id);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.Input;


                SqlParameter param7 = command.Parameters.AddWithValue("@capacity", capacity);
                param7.DbType = DbType.Int32;
                param7.Direction = ParameterDirection.Input;

                SqlParameter param10 = command.Parameters.AddWithValue("@examTime", examTime);
                param10.DbType = DbType.String;
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
   public int deleteECourse()
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
                command.CommandText = "deleteECourse";
                command.CommandType = CommandType.StoredProcedure;
                            
                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorStat", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@id",id);
                param2.DbType = DbType.Int32;
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
   public DataTable allECourse ()
   {
       DataTable dt = new DataTable();
        if (Codedore!="")
        {
           SqlConnection connection = new SqlConnection(connectionString);
           try
           {
               SqlParameter[] parameters = new SqlParameter[2];

               parameters[0] = new SqlParameter("@courseCode", SqlDbType.NVarChar, 20);
               parameters[0].Value = courseCode;
               
               parameters[1] = new SqlParameter("@Codedore", SqlDbType.NVarChar, 20);
               parameters[1].Value = Codedore;

               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allECourse", parameters);
               
           }
           finally
           {
               connection.Close();
           }
        }
       return dt;

   }
public DataTable allECourse_ForStudent ( string studentCode )
{
    DataTable dt = new DataTable();
        if (Codedore!="" )
        {
           SqlConnection connection = new SqlConnection(connectionString);
           try
           {
               SqlParameter[] parameters = new SqlParameter[1];

               parameters[0] = new SqlParameter("@studentCode", SqlDbType.NVarChar, 20);
               parameters[0].Value = studentCode;


               dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allECourse_ForStudent", parameters);
               
           }
           finally
           {
               connection.Close();
           }
        }
       return dt;
}
   public int  eCourseInfo ()
   {
	int success = -1;
        if (id>0 )
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@id", SqlDbType.Int , 32);
                parameters[0].Value = id  ;

                 int error = -2;
                parameters[1] = new SqlParameter("@errorSta", SqlDbType.Int, 32);
                parameters[1].Value =error ;
                
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "eCourseInfo" ,parameters );
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray ;
                courseCode = obj[1].ToString();
                Codedore  = obj[2].ToString();
               // branche  = int.Parse(obj[3].ToString());
                capacity  =int.Parse(obj[4].ToString());
                examDate = obj[5].ToString();
                examTime = obj[6].ToString();
                masterCode=obj[7].ToString();
                courseName = obj[8].ToString();
                success = 1;
            }
            finally
            {
                connection.Close();
            }
        }
        return success;
   }
   public DataTable  allECourseIdNameB ()
   {
       DataTable dt= new DataTable();
       if ( Codedore!="" )
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "allECourseIdNameB";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@Codedore",Codedore);
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
#endregion

    }
