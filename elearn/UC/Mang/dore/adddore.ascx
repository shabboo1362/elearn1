<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adddore.ascx.cs" Inherits="UC_Mang_dore_adddore" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف دوره تحصيلي &nbsp;جديد</td>
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
    style ="font-family:Arial ;font-size:16px; font-weight:bold ;"></asp:Label>&nbsp;&nbsp;&nbsp;
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td style="width: 179px">
    كد دوره :</td>
<td align ="right" >
    <asp:TextBox ID="dorecodetxt" runat="server" Width="161px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dorecodetxt"
        ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="width: 179px">
    ترم :</td>
<td align ="right" dir="rtl" colspan="5" >
    <asp:TextBox ID="termtxt" runat="server" Width="161px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد." ControlToValidate="termtxt">*</asp:RequiredFieldValidator></td>
</tr>
    <tr>
        <td style="width: 179px">
            سال :</td>
        <td align="right">
            <asp:TextBox ID="yeartxt" runat="server" Width="161px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="yeartxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
      <tr>
        <td style="width: 179px">
            وضعیت دوره :</td>
        <td align="right">
            <asp:RadioButton ID="rbtnSta1" runat="server" GroupName ="a"  Text ="دوره جاری"  Checked="true" Width="113px" />
            <asp:RadioButton ID="rbtnSta2" runat="server" GroupName ="a"  Text ="دوره شروع نشده" />
            </td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
