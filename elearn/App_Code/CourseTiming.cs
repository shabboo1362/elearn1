using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Dottext.Framework.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for CourseTiming
/// </summary>
public class CourseTiming
{
    #region Members
    private int idCourseE;
    private string  courseName;
    private int  courseBranch;
    private string  dorehCode;
    private string studCode;
    private int   timingCode;
    private string  connectionString;
    #endregion
    #region Properties
    public int IdCourseE
    {
        get { return idCourseE; }
        set { idCourseE = value; }
    }
    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }
    public int CourseBranch
    {
        get { return courseBranch; }
        set { courseBranch = value; }
    }
    public string DorehCode
    {
        get { return dorehCode; }
        set { dorehCode = value; }
    }
    public string StudCode
    {
        get { return studCode; }
        set { studCode = value; }
    }
    public int TimingCode
    {
        get { return timingCode; }
        set { timingCode = value; }
    }
    #endregion
    public CourseTiming()
	{
        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;
	}
    #region method
    public int newCourseTiming ()
   {
     int success = -1;
        if (idCourseE>0 )
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newCourseTiming";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@timingCode", timingCode);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@idCourseE", idCourseE);
                param2.DbType = DbType.Int64;
                param2.Direction = ParameterDirection.Input;

               
                int error = -2;
                SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
                param8.DbType = DbType.Int32;
                param8.Direction = ParameterDirection.InputOutput;

                command.ExecuteNonQuery();
                success = Convert.ToInt32(command.Parameters["@errorSta"].Value);
                if (success == 1)
                {
                    idCourseE = Convert.ToInt32(command.Parameters["@idCourseE"].Value);
                }
            }
            finally
            {
                connenction.Close();
            }
        }
        return success;

   }

   public void deleteCourseTiming()
   {
      
        if ( idCourseE > 0 && timingCode > 0)
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteCourseTiming";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@timingCode", timingCode);
                param1.DbType = DbType.Int32;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@idCourseE", idCourseE);
                param2.DbType = DbType.Int64;
                param2.Direction = ParameterDirection.Input;

            }
            finally
            {
                connenction.Close();
            }
        }
      
			    
  }
   public DataTable allCourseTiming ()
   {
       DataTable dt = new DataTable();
       if(idCourseE>0)
       {
	    SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        SqlParameter[] parameters = new SqlParameter[1];

        parameters[0] = new SqlParameter("@idCourseE", SqlDbType.Int,8);
        parameters[0].Value = idCourseE;
        try
        {
            dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allCourseTiming",parameters);

        }
        finally
        {

            connection.Close();
        }
       }
        return dt;	        
   }
   public DataTable allCourseTimingForStud ()
   {
       DataTable dt = new DataTable();
       if (idCourseE >0)
       {
           SqlConnection connenction = new SqlConnection(connectionString);
           try
           {
               connenction.Open();
               SqlCommand command = new SqlCommand();

               command.Connection = connenction;
               command.CommandText = "allCourseTimingForStud";
               command.CommandType = CommandType.StoredProcedure;

               SqlParameter param1 = command.Parameters.AddWithValue("@studCode", timingCode);
               param1.DbType = DbType.String;
               param1.Direction = ParameterDirection.Input;

               int error = -2;
               SqlParameter param8 = command.Parameters.AddWithValue("@errorSta", error);
               param8.DbType = DbType.Int32;
               param8.Direction = ParameterDirection.InputOutput;

               dt = SqlHelper.ExecuteDataTable(connenction, CommandType.StoredProcedure, "allCourseTiming");

           }
           finally
           {
               connenction.Close();
           }
       }
       return dt;
	        
   }
#endregion

}

