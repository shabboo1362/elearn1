using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Dottext.Framework.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Tuition
/// </summary>
public class Tuition
{
    #region Members
    private string inputCode;
    private string filedCode;
    private string periodCode;
    private decimal tuition;
    private string connectionString;
    #endregion
    #region Properties
    public string InputCode
    {
        get { return inputCode; }
        set { inputCode = value; }
    }
    public string FiledCode
    {
        get { return filedCode; }
        set { filedCode = value; }
    }
    public string PeriodCode
    {
        get { return periodCode; }
        set { periodCode = value; }
    }
    public decimal Tuitions
    {
        get { return tuition; }
        set { tuition = value; }
    }
    #endregion
    public Tuition()
    {

        connectionString = ConfigurationManager.ConnectionStrings["elearnCon"].ConnectionString;

    }
    

    public int newTuition()
    {
        int success = 0;
        if (inputCode != "" && filedCode != "" && periodCode != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "newTuition";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@inputCode", inputCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@filedCode", filedCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@tuition", tuition);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@periodCode", periodCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param6 = command.Parameters.AddWithValue("@errorSta", error);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.InputOutput;

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
    public int updateTuition()
    {
        int success = 0;
        if (inputCode != "" && filedCode != "" && periodCode != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "updateTuition";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@inputCode", inputCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@filedCode", filedCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@tuition", tuition);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@periodCode", periodCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param6 = command.Parameters.AddWithValue("@errorSta", error);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.InputOutput;

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

    public int deleteTuition()
    {
        int success = 0;
        if (inputCode != "" && filedCode != "" && periodCode != "")
        {
            SqlConnection connenction = new SqlConnection(connectionString);
            try
            {
                connenction.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connenction;
                command.CommandText = "deleteTuition";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = command.Parameters.AddWithValue("@inputCode", inputCode);
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input;

                SqlParameter param2 = command.Parameters.AddWithValue("@filedCode", filedCode);
                param2.DbType = DbType.String;
                param2.Direction = ParameterDirection.Input;

                SqlParameter param4 = command.Parameters.AddWithValue("@tuition", tuition);
                param4.DbType = DbType.Decimal;
                param4.Direction = ParameterDirection.Input;

                SqlParameter param5 = command.Parameters.AddWithValue("@periodCode", periodCode);
                param5.DbType = DbType.String;
                param5.Direction = ParameterDirection.Input;

                int error = -2;
                SqlParameter param6 = command.Parameters.AddWithValue("@errorSta", error);
                param6.DbType = DbType.Int32;
                param6.Direction = ParameterDirection.InputOutput;

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
    public DataTable allTuition()
    {
        int success = 0;
        DataTable dt = new DataTable();
        if (inputCode != "" && filedCode != "" && periodCode != "")
        {
            SqlParameter[] parameters = new SqlParameter[3];
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            try
            {

                parameters[0] = command.Parameters.AddWithValue("@inputCode", inputCode);
                parameters[0].DbType = DbType.String;
                parameters[0].Direction = ParameterDirection.Input;

                parameters[1] = command.Parameters.AddWithValue("@filedCode", filedCode);
                parameters[1].DbType = DbType.String;
                parameters[1].Direction = ParameterDirection.Input;

                parameters[2] = command.Parameters.AddWithValue("@periodCode", periodCode);
                parameters[2].DbType = DbType.String;
                parameters[2].Direction = ParameterDirection.Input;

                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "allTuition", parameters);

            }
            finally
            {
                connection.Close();
            }
        }
        return dt;
    }
    public int tuitionInfo()
    {
        int success = -1;
        if (inputCode != "" && filedCode != "" && periodCode != "")
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];

                parameters[0] = new SqlParameter("@inputCode", SqlDbType.NVarChar, 20);
                parameters[0].Value = inputCode;

                parameters[1] = new SqlParameter("@filedCode", SqlDbType.NVarChar, 20);
                parameters[1].Value = filedCode;

                parameters[2] = new SqlParameter("@periodCode", SqlDbType.NVarChar, 20);
                parameters[2].Value = periodCode;


                dt = SqlHelper.ExecuteDataTable(connection, CommandType.StoredProcedure, "tuitionInfo", parameters);
                if (dt.Rows.Count == 0)
                {
                    success = -1;
                    return success;
                }
                object[] obj = dt.Rows[0].ItemArray;
                tuition =decimal.Parse(obj[3].ToString());

            }
            finally
            {
                connection.Close();
            }
        }
        return success;
    }

	

}
