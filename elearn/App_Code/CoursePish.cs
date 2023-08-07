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
/// Summary description for CoursePish
/// </summary>
public class CoursePish
{
    #region Members
    private string courseCode;
    private string courseName;
    private string coursePishCode;
    private string coursePishName;
    private string filedCode;
    private string filedName;
    private byte type;//یک به معنای پیش نیاز و دو به معنای هم نیاز

    private string connectionString;
    #endregion
    #region Properties
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
    public string CoursePishCode
    {
        get { return coursePishCode; }
        set { coursePishCode = value; }
    }

    public string CoursePishName
    {
        get { return coursePishName; }
        set { coursePishName = value; }
    }
    public string FiledName
    {
        get { return filedName; }
        set { filedName = value; }
    }
    public string FiledCode
    {
        get { return filedCode; }
        set { filedCode = value; }
    }
    public byte Type
    {
        get { return type; }
        set { type = value; }
    }
    #endregion
    
    #region Methods

    public int newCoursePish()
    {
        int success = -1;
        if (courseCode == coursePishCode)
            return -4;

        if (courseCode != "" && coursePishCode != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newCoursePish";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@coursePishCode", coursePishCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@type", type);
                param4.DbType = DbType.String;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param5.DbType = DbType.String;
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
    public int deleteCoursePish()
    {
        int success = -3;
        if (courseCode !="" && coursePishCode!="")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteCoursePish";
                command.CommandType = CommandType.StoredProcedure;

                int error = -2;
                SqlParameter param1 = command.Parameters.AddWithValue("@errorStat", error);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.InputOutput;

                SqlParameter param2 = command.Parameters.AddWithValue("@courseCode", courseCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param3 = command.Parameters.AddWithValue("@coursePishCode", coursePishCode);
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

    public DataTable allCoursePish()
    {
        DataTable dt = new DataTable();
        if (courseCode != "")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@CourseCode", SqlDbType.NVarChar, 20);
            parameters[0].Value = CourseCode;
            try
            {
                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCoursePish", parameters);

            }
            finally
            {

                connection.Close();
            }
        }
        return dt;
    }
   
#endregion
    public CoursePish()
    {
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
    }

}