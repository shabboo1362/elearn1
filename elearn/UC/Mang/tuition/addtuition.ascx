<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addtuition.ascx.cs" Inherits="UC_Mang_tuition_addtuition" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       شهريه جديد</td>
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
   كد رشته :</td>
<td align ="right" dir="rtl" colspan="5" ><asp:DropDownList ID="reshtecodeddl" runat="server" Width="134px" DataTextField="Name1" DataValueField="codeReshteh">
</asp:DropDownList>&nbsp;
</td>
</tr>
    <tr>
        <td style="height: 24px">
            كد دوره :</td>
        <td align="right" style="height: 24px"><asp:DropDownList ID="dorecodeddl" runat="server" Width="134px" DataTextField="CodeDoreh" DataValueField="CodeDoreh">
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            ورودي :</td>
        <td align="right" style="height: 22px">
            <asp:DropDownList ID="vorodiddl" runat="server" ReadOnly="True" Width="131px" DataTextField="CodeDoreh" DataValueField="CodeDoreh" ></asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            شهريه :</td>
        <td style="height: 26px">
            <asp:TextBox ID="tuitiontxt" runat="server" Width="110px"></asp:TextBox></td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
