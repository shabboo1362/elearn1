using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for register
/// </summary>
public class Register
{
	#region Members
    private string  Id;
    private string  Tuition;
    private string  Tuitionstatus;
    private string  Gread;
    private string  GreadNomehState;
    private string  CodeStudent;// شماره دانشجو
    private string  CourseEID;//  Id درس ارائه شده
    private string  StateCourse;// حالت درس که میتواند مقادیر انتظار یا ثبت توسط کاربر یا ثبت توسط مدیر را داشته باشد.

    private string  connectionString;
    #endregion
    #region Properties
	 public string codeStudent
    {
        get { return CodeStudent; }
        set { CodeStudent = value; }
    }
    public string courseEID
    {
        get { return CourseEID; }
        set { CourseEID = value; }
    }
    public string stateCourse
    {
        get { return StateCourse; }
        set { StateCourse  = value; }
    }
     public string id
    {
        get { return Id; }
        set { Id  = value; }
    }
     public string tuition
    {
        get { return Tuition; }
        set { Tuition  = value; }
    }
     public string tuitionstatus
    {
        get { return Tuitionstatus; }
        set { Tuitionstatus  = value; }
    }
     public string gread
    {
        get { return Gread; }
        set { Gread  = value; }
    }
     public string greadNomehState
    {
        get { return GreadNomehState; }
        set { GreadNomehState  = value; }
    }
    #endregion
    public Register ()
	{
         CodeStudent = "";
         CourseEID ="";
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    #region Methods
    /*
   public int newRegister ()
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
   public int updateRegister()
   {

   }
 public int deleteRegister ()
   {   
   }
public int  allCourseStudent ()
{
}*/
#endregion
}
