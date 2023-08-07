<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addreshte.ascx.cs" Inherits="UC_Mang_reshte_addreshte" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف رشته تحصيلي جديد</td>
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
<td style="height: 20px; width: 205px;">
    كد رشته :</td>
<td align ="right" style="height: 20px" >
    <asp:TextBox ID="reshtecodetxt" runat="server" Width="149px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="reshtecodetxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="width: 205px">
    نام رشته :</td>
<td align ="right" dir="rtl" colspan="5" >
    <asp:TextBox ID="reshtenametxt" runat="server" Width="152px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="reshtenametxt">*</asp:RequiredFieldValidator></td>
</tr>
    <tr>
        <td style="width: 205px;">
            نام مقطع :</td>
        <td align="right">
            <asp:DropDownList ID="maghtaanameddl" runat="server" Width="156px" DataTextField="nameMaghtaa" DataValueField="nameMaghtaa">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="maghtaanameddl">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 205px; height: 21px;">
            تعداد واحد عمومي :</td>
        <td align="right" style="height: 21px">
            <asp:TextBox ID="vomomitxt" runat="server" Width="108px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="vomomitxt">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 205px">
            تعداد واحد تخصصي ضروري :</td>
        <td align="right" style="height: 22px">
            <asp:TextBox ID="vtakhasisitxt" runat="server" Width="110px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="vtakhasisitxt">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 205px">
            تعداد واحد تخصصي اختياري :</td>
        <td align="right">
            <asp:TextBox ID="vekhtiaritxt" runat="server" Width="110px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="vekhtiaritxt">*</asp:RequiredFieldValidator></td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
