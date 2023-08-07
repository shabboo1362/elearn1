<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manag.aspx.cs" Inherits="ControlPanel_manag"  ValidateRequest ="false" %>

<%@ Register Src="../UC/Mang/News/deletenews.ascx" TagName="deletenews" TagPrefix="uc2" %>

<%@ Register Src="../UC/Mang/News/newsmanag.ascx" TagName="newsanag" TagPrefix="uc1" %>

<%@ Register Src="../UC/Mang/News/AddNews.ascx" TagName="AddNews" TagPrefix="wm" %>
<%@ Register Src="../UC/Mang/News/updatenews.ascx" TagName="updatenews" TagPrefix="uc3" %>

<%@ Register Src="../UC/Mang/course/coursemanag.ascx" TagName="coursemanag" TagPrefix="uc4" %>

<%@ Register Src="../UC/Mang/course/addcourse.ascx" TagName="addcourse" TagPrefix="uc5" %>
<%@ Register Src="../UC/Mang/course/deletecourse.ascx" TagName="deletecourse" TagPrefix="uc6" %>
<%@ Register Src="../UC/Mang/coursepish/pishmanag.ascx" TagName="pishmanag" TagPrefix="uc7" %>
<%@ Register Src="../UC/Mang/coursetiming/coursetimingmanage.ascx" TagName="coursetimingmanage" TagPrefix="uc8" %>

<%@ Register Src="~/UC/Mang/coursetype/coursetypemanage.ascx" TagName="typemanag" TagPrefix="uc9" %>
<%@ Register Src="~/UC/Mang/coursetype/deletecoursetype.ascx" TagName="deletetype" TagPrefix="uc10" %>
<%@ Register Src="~/UC/Mang/coursetype/newcoursetype.ascx" TagName="newtype" TagPrefix="uc11" %>
<%@ Register Src="~/UC/Mang/dore/adddore.ascx" TagName="adddore" TagPrefix="uc12" %>
<%@ Register Src="~/UC/Mang/dore/deletdore.ascx" TagName="deletedore" TagPrefix="uc13" %>
<%@ Register Src="~/UC/Mang/dore/doremanag.ascx" TagName="doremanag" TagPrefix="uc14" %>
<%@ Register Src="~/UC/Mang/ecourse/addecourse.ascx" TagName="addecourse" TagPrefix="uc15" %>
<%@ Register Src="~/UC/Mang/ecourse/deleteecourse.ascx" TagName="deleteecourse" TagPrefix="uc16" %>
<%@ Register Src="~/UC/Mang/ecourse/ecoursemanag.ascx" TagName="ecoursemanag" TagPrefix="uc17" %>
<%@ Register Src="~/UC/Mang/Maghtaa/addmaghtaa.ascx" TagName="addmaghtaa" TagPrefix="uc18" %>
<%@ Register Src="~/UC/Mang/Maghtaa/deletemaghtaa.ascx" TagName="deletemaghtaa" TagPrefix="uc19" %>
<%@ Register Src="~/UC/Mang/Maghtaa/maghtaamanag.ascx" TagName="maghtaamanag" TagPrefix="uc20" %>
<%@ Register Src="~/UC/Mang/master/addmaster.ascx" TagName="addmaster" TagPrefix="uc21" %>
<%@ Register Src="~/UC/Mang/master/deletemasterl.ascx" TagName="deletemaster" TagPrefix="uc22" %>

<%@ Register Src="~/UC/Mang/master/mastermanag.ascx" TagName="mastermanag" TagPrefix="uc23" %>
<%@ Register Src="~/UC/Mang/registertiming/addregistertiming.ascx" TagName="addregtiming" TagPrefix="uc24" %>
<%@ Register Src="~/UC/Mang/registertiming/registertimingmanag.ascx" TagName="regtimingmanag" TagPrefix="uc25" %>
<%@ Register Src="~/UC/Mang/registertiming/delregistertiming.ascx" TagName="delregtimingmanag" TagPrefix="uc34" %>
<%@ Register Src="~/UC/Mang/reshte/addreshte.ascx" TagName="addreshte" TagPrefix="uc26" %>
<%@ Register Src="~/UC/Mang/reshte/deletereshte.ascx" TagName="deletereshte" TagPrefix="uc27" %>
<%@ Register Src="~/UC/Mang/reshte/reshtemanag.ascx" TagName="reshtemanag" TagPrefix="uc28" %>
<%@ Register Src="~/UC/Mang/student/addstudent.ascx" TagName="addstudent" TagPrefix="uc29" %>
<%@ Register Src="~/UC/Mang/student/deletestudent.ascx" TagName="deletestudent" TagPrefix="uc30" %>
<%@ Register Src="~/UC/Mang/student/studentmanag.ascx" TagName="studentmanag" TagPrefix="uc31" %>
<%@ Register Src="~/UC/Mang/tuition/addtuition.ascx" TagName="addtuition" TagPrefix="uc32" %>
<%@ Register Src="~/UC/Mang/tuition/tuitionmanag.ascx" TagName="managtuition" TagPrefix="uc33" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>Manag Page</title>
    <link rel="stylesheet" href="../Css/default.css" type="text/css" />
    <script type="text/javascript"  language="javascript" >
    function loadComplet()
     {
        var elem =document.getElementById("progress") ;
        if( elem)
            elem.style.display ="none" ;
       return true;
     }  
     function displayFun()
     {
        var elem =document.getElementById("phdiv") ;
        if( elem)
            elem.style.display ="none" ;
        elem =document.getElementById("progress") ;
        if( elem)
            elem.style.display ="block" ;
        window.document.form1.submit();    
        return true; 
     }   
     </script>
</head>
<body background ="../images/backManag.gif" onload ="loadComplet();">
    <form id="form1" runat="server" style ="padding-left:5px ;padding-top:5px">
    <div  id="progress"  dir="rtl" style ="text-align:center;">
      <table cellpadding="0" cellspacing="0" border="0" 
      style="border-right: white 1px solid; border-top: 
      white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid;height:10px;width:500px;height:30px" >
      <tr>
      <td style="font-size:12pt;font-family:Arial;
                font-weight:bold;background-color:#33ccff;color:White;text-align:center;">
        لطفا صبر کنید ( درحال اجرای دستور و باز سازی وب سایت ) &nbsp;<marquee behavior ="alternate" 
         scrollamount="1" scrolldelay="50" bgColor="#3300ff" 
             direction="left"  width="100px" height="10px" truespeed="true"><span 
      style="BACKGROUND-COLOR: white">&nbsp;&nbsp;</SPAN></marquee>
      </td>
      </tr>
      </table>
    </div>
    <div  id="phdiv">
        <asp:PlaceHolder ID="phMain" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
