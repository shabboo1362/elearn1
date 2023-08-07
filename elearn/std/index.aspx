<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="std_index" %>

<%@ Register Src="../UC/Public/News/studentNews.ascx" TagName="studentNews" TagPrefix="uc3" %>

<%@ Register Src="../UC/Mang/Register/newReg.ascx" TagName="newReg" TagPrefix="uc2" %>

<%@ Register Src="../UC/Mang/student/stdHome.ascx" TagName="stdHome" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" dir ="rtl" >
<head id="Head1" runat="server">
    <title>سیستم آموزش الکترونیکی - سامانه دانش آموزی</title>
   <link rel="stylesheet"  href  ="../Css/default.css" type ="text/css" />
</head>
<body style ="margin:0px 0px 0px 0px ;padding:0px 0px 0px 0px;" background="../images/bg-blue.jpg">
<center>
    <form id="form2" runat="server">
    <div style ="width:980px;background-color:White;">
    <table  cellpadding="0" cellspacing="0" border ="0" width  ="980px">
    <tr>
    <td colspan ="2" >
    <img alt ="" src ="../images/mainLogo.jpg" style="width:980px" />
    </td>
    </tr>
    <tr>
    <td colspan ="2" style ="padding:2px 2px 2px 2px;" >
    <table cellpadding="0" cellspacing="0" border ="0" width  ="976px" 
    style="border-right: #0000cc 1px solid;
     border-top: #0000cc 1px solid; border-left: #0000cc 1px solid; border-bottom: #0000cc 1px solid" background="../images/bg-stdTop.jpg">
    <tr>
    <td >
        شماره دانش آموزی:<asp:Label ID="lblNo" runat="server" Text="" ></asp:Label></td>
    <td >
        نام و نام خانوادگی :<asp:Label ID="lblName" runat="server" Text="" ></asp:Label>
    </td>
    <td >
        وضعیت آخرین ترم تحصیلی:<asp:Label ID="lblStatus" runat="server" Text="" ></asp:Label>
    </td>
    <td style="text-align: left" >
           <a href ="index.aspx">خانه</a></td>
           <td>
           <a href ="index.aspx"><img  src ="../images/Makehome.png" style ="border-width:0px;"/></a> 
           </td>
           <td style="text-align: left" >
           <a href ="index.aspx?page=singout">خروج از سیستم(بازگشت به صفحه اصلی)</a></td>
           <td>
           <a href ="index.aspx?page=singout"><img  src ="../images/exit.png" style ="border-width:0px;"/></a> 
           </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr >
    <td style ="width:770px;padding:20px 5px 5px 5px;vertical-align:top;">
       <asp:PlaceHolder ID="phContent" runat="server"></asp:PlaceHolder>
    </td>
    <td style ="width:210px;vertical-align:top;padding:20px 5px 5px 5px">
    <table dir ="rtl" cellpadding="0" cellspacing="0" border="0" width ="200px" >
<tr >
<td style ="background-repeat:repeat-y;text-align:right;padding-right:0px;vertical-align:baseline ;" background="../images/menuTop.jpg">
    &nbsp;</td>
</tr>
<tr><td align ="center" style="border-left: black 1px solid;border-right : black 1px solid;
font-family:Arial;font-size:12pt;font-weight:bold;text-align:right;padding-right:10px;color: deeppink"  >
    <asp:Label ID="lblTitle" runat="server" Text="">ویژه دانش آموزان</asp:Label></td>
</tr>
<tr><td align ="center" style="border-left: black 1px solid;border-right : black 1px solid;text-align:center;"  >
<br />
    <uc3:studentNews ID="StudentNews1" runat="server" />
</td>
</tr>
<tr>
<td style ="background-repeat:repeat-y;text-align:right;padding-right:0px;height:20px" background="../images/menuBack.jpg">
    &nbsp;</td>
</tr>
</table>
    </td>
    
    </tr>
     <tr><td style="height:50px; color: #ffffff;text-align:center;" background="../images/backbotton4.jpg" colspan="2">
         <br />
            طراحی و پشتیبانی از <a href="http://www.webmedia.co.ir" style="color: #ffffff">
                    شرکت رایانه ای وب میدیا</a>
            </td>
        </tr>
    </table>
    </div>
    </form></center>
</body>
</html>

