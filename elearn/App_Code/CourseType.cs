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
/// Summary description for CourseType
/// </summary>
public class CourseType
{
    #region Members
    private string courseType;
    private string Codedore;
    private decimal courseTuition;
    private string newcourseType;
    private string filedCode;
    private string connectionString;
    #endregion
     #region Properties
    public string COurseType
    {
        get { return courseType; }
        set { courseType = value; }
    }
    public string CodeDore
    {
        get { return Codedore; }
        set { Codedore = value; }
    }
    public decimal CourseTuition
    {
        get { return courseTuition; }
        set { courseTuition = value; }
    }

    public string NewcourseType
    {
        get { return newcourseType; }
        set { newcourseType = value; }
    }
    public string FiledCode
    {
        get { return filedCode; }
        set { filedCode = value; }
    }
    #endregion
	public CourseType()
	{
        courseType = "";
        courseTuition = 0;
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
	}
    #region methods
    public int newCourseType()
   {
	 int success = -1;
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newCourseType";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@courseType", courseType);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@Codedore", Codedore);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseTuition", courseTuition);
                param5.DbType = DbType.Decimal;
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
        return success;	        
       }
   public int updateCourceType()
   {
       int success = -1;
        if (courseType!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateCourceType";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = command.Parameters.AddWithValue("@courseType", courseType);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@Codedore", Codedore);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@courseTuition", courseTuition);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@newcourseType", newcourseType);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.InputOutput;

                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;

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
   public int deleteCourseType()
   {
    int success = -3;
    if (courseType!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteCourseType";
                command.CommandType = CommandType.StoredProcedure;

                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorStat", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@courseType", courseType);
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
   public DataTable allCourseTypeIdName()
   {
	        DataTable dt= new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "allCourseTypeIdName";
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCourseTypeIdName");

           }
           finally
            {
                connection.Close();
            }
       return dt;
   }
   public DataTable allCourseType()
   {
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt = new DataTable();
        try
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Codedore", SqlDbType.NVarChar, 20);
            parameters[0].Value = Codedore;

            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCourseType",parameters);

        }
        finally
        {

            connection.Close();
        }
        return dt;	        
   }
#endregion

}
