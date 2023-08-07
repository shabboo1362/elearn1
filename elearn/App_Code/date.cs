using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Globalization;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for date
/// </summary>
public class date
{
	public date()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string GetPersianDateString1(DateTime? dt)
    {
        if (dt == null) return string.Empty;
        PersianCalendar calendar = new PersianCalendar();
        int year = calendar.GetYear(dt.Value);
        int month = calendar.GetMonth(dt.Value);
        int day = calendar.GetDayOfMonth(dt.Value);
        string year1 = year.ToString();
        string month1 = month.ToString();
        string day1 = day.ToString();
        if (month < 10)
            month1 = "0" + month.ToString();
        if (day < 10)
            day1 = "0" + day.ToString();
        string text = string.Format("{0}/{1}/{2}", year1, month1, day1);
        return text;
    }
}
