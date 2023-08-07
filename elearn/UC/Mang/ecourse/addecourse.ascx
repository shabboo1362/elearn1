<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addecourse.ascx.cs" Inherits="UC_Mang_ecourse_addecourse" %>
<%@ Register Assembly="AspNetPersianDatePickup" Namespace="AspNetPersianDatePickup" TagPrefix="pcal" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف درس جدید براي ارائه</td>
   </tr>
<tr style="height:40px"><td colspan="6" style ="font-family:Arial ;font-size:16px; font-weight:bold ;
vertical-align:middle;border-bottom: maroon 2px solid;">
<table cellpadding="5" border="0"  width ="100%" >
<tr>
<td style ="text-align:center ;width:40px">
<asp:Image ID="imSuccess" runat="server" Height="25px" ImageUrl="../../../images/succes.GIF"
        Visible="false" Width="25px" /></td>
<td   style="vertical-align:middle;" colspan="5" >
    <asp:Label ID="lblMessage" runat="server" 
    style ="font-family:Arial ;font-size:16px; font-weight:bold ;"></asp:Label>&nbsp;
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td>
    كد دوره :</td>
<td align ="right" ><asp:DropDownList ID="dorecodeddl" runat="server" Width="136px" DataTextField="CodeDoreh" DataValueField="CodeDoreh">
</asp:DropDownList></td>
</tr>
<tr>
<td>
    كد &nbsp;درس :</td>
<td align ="right" dir="rtl" colspan="5" ><asp:DropDownList ID="coursecodeddl" runat="server" Width="134px" DataTextField="Name1" DataValueField="courseCode">
</asp:DropDownList>&nbsp;
</td>
</tr>
    <tr>
        <td style="height: 24px">
            كد مدرس :</td>
        <td align="right" style="height: 24px"><asp:DropDownList ID="mastercodeddl" runat="server" Width="134px" DataTextField="Name1" DataValueField="userCode">
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            ظرفيت :</td>
        <td align="right" style="height: 22px">
            <asp:TextBox ID="capasitytxt" runat="server" Width="110px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            تاريخ امتحان :</td>
        <td style="height: 26px"><pcal:PersianDatePickup ID="pdp" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
       </td>
    </tr>
   <tr>
   <td style="height: 40px">
       ساعت امتحان :</td>
   <td style="height: 40px">
       <asp:TextBox ID="examtimetxt" runat="server" Width="110px"></asp:TextBox></td>
   </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
