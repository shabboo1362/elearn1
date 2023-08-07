<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addmaghtaa.ascx.cs" Inherits="UC_Mang_Maghtaa_addmaghtaa" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف مقطع تحصيلي جديد</td>
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
    نام مقطع :</td>
<td align ="right" style="height: 20px" >
    <asp:TextBox ID="namemaghtaatxt" runat="server" Width="161px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="namemaghtaatxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="width: 205px">
    حداقل واحد قابل اخذ:</td>
<td align ="right" dir="rtl" colspan="5" >
    <asp:TextBox ID="minvahedtxt" runat="server" Width="161px">8</asp:TextBox></td>
</tr>
    <tr>
        <td style="width: 205px;">
            معدل A:</td>
        <td align="right">
            <asp:TextBox ID="moadelatxt" runat="server" Width="161px">17</asp:TextBox>
            </td>
    </tr>
    <tr>
        <td style="width: 205px; height: 21px;">
            معدل مشروطي :</td>
        <td align="right" style="height: 21px">
            <asp:TextBox ID="moadelmtxt" runat="server" Width="161px">12</asp:TextBox>
            </td>
    </tr>
    <tr>
        <td style="width: 205px">
            حداكثر واحد در حالت مشروطي :</td>
        <td align="right" style="height: 22px">
            <asp:TextBox ID="maxvmtxt" runat="server" Width="110px">14</asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 205px">
            حداكثر واحد در معدل A :</td>
        <td align="right">
            <asp:TextBox ID="maxvatxt" runat="server" Width="110px">24</asp:TextBox></td>
    </tr>
   <tr>
   <td style="height: 40px; width: 205px;">
       حداكثر واحد در حالت عادي:</td>
   <td style="height: 40px">
       <asp:TextBox ID="maxvgtxt" runat="server" Width="110px">20</asp:TextBox></td>
   </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
