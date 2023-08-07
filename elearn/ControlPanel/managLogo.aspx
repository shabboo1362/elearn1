<%@ Page Language="C#" AutoEventWireup="true" CodeFile="managLogo.aspx.cs" Inherits="ControlPanel_managLogo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Online Media Controlpanel</title>
    <link rel="stylesheet"  href  ="../Css/default.css" type ="text/css" />
</head>
<body style ="margin:0px 0px 0px 0px">
<table border= "0"  cellpadding="0"  cellspacing="0" style ="border-bottom:solid 2px #000000" >
<tr>
<td    align="center" valign="top" ><img  src ="../images/mediaManag.jpg"  alt ="" /></td>
<td  background ="../images/topManagBack.gif" align="center" width="100%" style ="background-repeat:repeat-x;">
<table border ="0"  cellpadding="0"  cellspacing="0"  width ="100%">
<tr >
<td >
<table border= "0"  cellpadding="0"  cellspacing="0">
<tr>
<td dir="rtl" style="Color:White; height: 19px;">کنـترل پنل اختصاصـی مدیریت وب سایت <br />
 کاربر :<asp:Label ID="lblUser" runat="server" Width="125px" 
    Font-Names="Arial" Font-Size="12pt" Font-Bold="True" ForeColor="#FFFFFF" ></asp:Label>
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td >
 <table  border= "0"  cellpadding="4px"  cellspacing="0">
    <tr>
        <td><a href ="content.htm" target="menu" >
        <img src="../images/countent.png"  alt ="" style="border-width:0px"/></a></td>
        <td><a href ="content.htm" target="menu" class="menu2"  >مدیریت محتوا و اخبار</a></td>
        
        <td><a href ="base.htm" target="menu" >
        <img src="../images/countent.png"  alt ="" style="border-width:0px"/></a></td>
        <td><a href ="base.htm" target="menu" class="menu2"  >مدیریت بیس</a></td>
        
        <td><a href ="doreh.htm" target="menu" >
        <img src="../images/countent.png"  alt ="" style="border-width:0px"/></a></td>
        <td><a href ="doreh.htm" target="menu" class="menu2"  >مدیریت دوره</a></td>
        
        <td><a href ="Statisticmenu.htm" target="menu" >
        <img src="../images/statistic.png"  alt =""   style="border-width:0px"/></a></td>
        <td><a href ="Statisticmenu.htm" target="menu" class="menu2"  >آمار وب سایت</a></td>
        
        <td><a href ="user.htm" target="menu" >
        <img src="../images/user.png"  alt =""   style="border-width:0px"/></a></td>
        <td><a href ="user.htm" target="menu" class="menu2" >کاربران</a></td>
        
        <td><a href ="index.aspx?page=logout" target="_parent"  >
        <img src="../images/exit.png"  alt =""   style="border-width:0px"/></a></td>
        <td><a href ="index.aspx?page=logout" target="_parent"  class="menu2" >خروج</a></td>
        
    </tr>
    </table>
</td>
</tr>
</table>
</td>
</tr>
</table>
</body>
</html>
