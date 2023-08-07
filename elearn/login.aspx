<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir ="rtl" >
<head id="Head1" runat="server">
    <title>سیستم آموزش الکترونیکی</title>
   <link rel="stylesheet"  href  ="./Css/default.css" type ="text/css" />
</head>
<body style ="margin:0px 0px 0px 0px ;padding:0px 0px 0px 0px;" background="./images/bg-blue.jpg">
<center>
    <form id="form2" runat="server">
    <div style ="width:980px;background-color:White;">
    <table  cellpadding="0" cellspacing="0" border ="0" width  ="980px">
    <tr>
    <td colspan ="2" >
    <img alt ="" src ="./images/mainLogo.jpg" style="width:980px" />
    </td>
    </tr>
    <tr style ="padding-top:20px;height:500px">
    <td colspan="2" style="text-align: center" >
      <asp:Login ID="Login1" runat="server" Width="396px">
        </asp:Login>
    
    </td>
    
    </tr>
     <tr><td style="height:50px; color: #ffffff;text-align:center;" background="./images/backbotton4.jpg" colspan="2">
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