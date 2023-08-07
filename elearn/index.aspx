<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Register Src="UC/Public/News/pageContext.ascx" TagName="pageContext" TagPrefix="uc2" %>

<%@ Register Src="UC/Public/News/topNewsHome.ascx" TagName="topNewsHome" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head runat="server">
    <title>سیستم آموزش الکترونیکی</title>
   <link rel="stylesheet"  href  ="./Css/default.css" type ="text/css" />
</head>
<body style ="margin:0px 0px 0px 0px ;padding:0px 0px 0px 0px;" background="./images/bg-blue.jpg">
<center>
    <form id="form1" runat="server">
    <div style ="width:980px;background-color:White;">
    <table  cellpadding="0" cellspacing="0" border ="0" width  ="980px">
    <tr>
    <td colspan ="2" >
    <img alt ="" src ="images/mainLogo.jpg" style="width:980px" />
    </td>
    </tr>
    <tr style ="padding-top:20px;height:500px">
    <td style ="width:770px;padding:0px 5px 5px 5px;vertical-align:top;">
       <asp:PlaceHolder ID="phContent" runat="server"></asp:PlaceHolder>
    </td>
    <td style ="width:210px;vertical-align:top;padding:0px 5px 5px 5px">
    <table dir ="rtl" cellpadding="0" cellspacing="0" border="0" width ="200px" >
<tr >
<td style ="background-repeat:repeat-y;text-align:right;padding-right:0px;vertical-align:baseline ;" background="./images/menuTop.jpg">
    &nbsp;</td>
</tr>
<tr><td align ="center" style="border-left: black 1px solid;border-right : black 1px solid;
font-family:Arial;font-size:12pt;font-weight:bold;text-align:right;padding-right:10px;color: deeppink"  >
    <asp:Label ID="lblTitle" runat="server" Text=""> سامانه های سیستم </asp:Label></td>
</tr>
<tr><td align ="center" style="border-left: black 1px solid;border-right : black 1px solid;text-align:center;"  >
<br />
<table cellpadding="5"  cellspacing="0" border="0" width="100%" >
    <tr>
        <td style="color: white">
            <a  href ="./prof/index.aspx" class ="menu2">
            <img  src="./images/master.jpg"  alt ="سامانه مدرسین"   style="border-width:0px;"/></a></td>
        <td>
        <a  href ="./prof/index.aspx" class ="menu2"> سامانه مدرسین&nbsp;</a>
        </td>
    </tr>    
    <tr>
    <td style="color :White;">
    <a  href ="./std/index.aspx" class ="menu2">
    <img  src="./images/studentS.jpg"  alt ="سامانه دانش آموزی"   style="border-width:0px;"/></a>
    </td>
    <td>
    <a  href ="./std/index.aspx" class ="menu2">  سامانه دانش آموزی</a></td>
    </tr>
    <tr>
    <td style="color :White;">
    <a  href ="./online/index.aspx" class ="menu2">
    <img  src="./images/onlineClass.jpg"  alt ="کلاس های آنلاین"   style="border-width:0px;width:60px;height:60px;"/></a>
    </td>
    <td>
    <a  href ="./online/index.aspx" class ="menu2">  کلاس های آنلاین</a></td>
    </tr>
    <tr>
    <td style="color :White;">
    <a  href ="./parent/index.aspx" class ="menu2">
    <img  src="./images/parent.jpg"  alt ="سامانه اولیاء"   style="border-width:0px;width:60px;height:60px;"/></a>
    </td>
    <td>
    <a  href ="./parent/index.aspx" class ="menu2"> سامانه اولیاء</a></td>
    </tr>
    <tr>
    <td style="color :White;">
    <a  href ="./public/index.aspx" class ="menu2">
    <img  src="./images/publicRelation.jpg"  alt ="روابط عمومی و اطلاع رسانی"   style="border-width:0px;"/></a>
    </td>
    <td>
    <a  href ="./public/index.aspx" class ="menu2">  روابط عمومی و اطلاع رسانی</a></td>
    </tr>
    </table>

</td>
</tr>
<tr>
<td style ="background-repeat:repeat-y;text-align:right;padding-right:0px;height:20px" background="./images/menuBack.jpg">
    &nbsp;</td>
</tr>
</table>
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
