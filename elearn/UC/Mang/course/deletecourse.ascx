<table dir  = "rtl" border ="0" cellpadding ="0" cellspacing ="0" width  ="95%" 
style="border-right: green thin solid; border-top: green thin solid; border-left:
 green thin solid; border-bottom: green thin solid"  >
<tr>
<td style="vertical-align:middle ;text-align:center ;width:15px ; height: 38px;" >
    <img  src ="../images/warning.GIF" alt =""  /></td>
<td style="text-align: right ;font-family:Arial; font-size:12pt ; font-weight:bold ;">
    <span style="color: #ff0000"></span>
        
    <asp:Label ID="lblMessage" runat="server" style="font-weight: bold; font-size: 16px; font-family: Arial" ForeColor="Red">
    
    </asp:Label>&nbsp;</td>
</tr>
<tr>
        <td colspan="2" style="height: 25px; text-align: center">
    <asp:Button ID="btnDel" runat="server" Text="تایید حذف" Font-Names="Arial" 
    Font-Size="16px" OnClick="btnDel_Click" Width="220px" OnClientClick="displayFun();"  />
    <asp:Button ID="Button1" runat="server" Font-Names="Arial" Font-Size="16px" OnClick="Button1_Click"
        Text="انصراف از حذف" Width="220px" /></td>
    </tr>
</table><%@ Control Language="C#" AutoEventWireup="true" CodeFile="deletecourse.ascx.cs" Inherits="UC_Mang_course_deletecourse" %>
