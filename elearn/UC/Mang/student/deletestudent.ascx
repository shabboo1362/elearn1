<%@ Control Language="C#" AutoEventWireup="true" CodeFile="deletestudent.ascx.cs" Inherits="UC_Mang_student_deletestudent" %>
<table dir  = "rtl" border ="0" cellpadding ="0" cellspacing ="0" width  ="95%" 
style="border-right: green thin solid; border-top: green thin solid; border-left:
 green thin solid; border-bottom: green thin solid"  >
<tr>

    <td >
    
    <asp:Image ID="imSuccess" runat="server" Height="25px" ImageUrl="../../../images/succes.GIF"
        Visible="false" Width="25px" /></td>
<td style="text-align: right ;font-family:Arial; font-size:12pt ; font-weight:bold ;">
    <span style="color: #ff0000">توجه</span>: <asp:Label ID="lblMessage" runat="server" style="font-weight: bold; font-size: 16px; font-family: Arial" ForeColor="Red">
    
    </asp:Label>
    </td>
</tr>
<tr>
        <td colspan="2" style="height: 25px; text-align: center">
    <asp:Button ID="btnDel" runat="server" Text="تایید حذف" Font-Names="Arial" 
    Font-Size="16px" OnClick="btnDel_Click" Width="220px" OnClientClick="displayFun();"  />
    <asp:Button ID="Button1" runat="server" Font-Names="Arial" Font-Size="16px" OnClick="Button1_Click"
        Text="انصراف از حذف" Width="220px" /></td>
    </tr>
</table>