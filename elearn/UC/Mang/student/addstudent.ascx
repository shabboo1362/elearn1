<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addstudent.ascx.cs" Inherits="UC_Mang_student_addstudent" %>
<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف كاربر مديريتي و مدرس جدید </td>
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
    style ="font-family:Arial ;font-size:16px; font-weight:bold ;"></asp:Label>&nbsp;&nbsp;
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td style="width: 204px">
    شماره دانشجويي :</td>
<td align ="right" >
    <asp:TextBox ID="usercodetxt" runat="server" Width="110px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usercodetxt"
        ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="width: 204px">
    نام&nbsp; :</td>
<td align ="right" dir="rtl" >
    <asp:TextBox ID="nametxt" runat="server" Width="110px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="nametxt"
        ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
</tr>
    <tr>
        <td style="width: 204px">
            نام خانوادگي&nbsp; :</td>
        <td align="right">
            <asp:TextBox ID="familytxt" runat="server" Width="109px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="familytxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 204px">
            نام پدر :</td>
        <td align="right">
            <asp:TextBox ID="fathertxt" runat="server" Width="110px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="fathertxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 204px">
            كد ملي :</td>
        <td align="right" style="height: 22px">
            <asp:TextBox ID="codemelitxt" runat="server" Width="110px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="codemelitxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 204px">
            ش ش :</td>
        <td align="right">
            &nbsp;<asp:TextBox ID="shshtxt" runat="server" Width="108px"></asp:TextBox><asp:RequiredFieldValidator
                ID="RequiredFieldValidator2" runat="server" ControlToValidate="shshtxt" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 204px">
            ت ت :</td>
        <td align="right">
            <asp:TextBox ID="tarikhttxt" runat="server" Width="108px"></asp:TextBox><asp:RequiredFieldValidator
                ID="RequiredFieldValidator7" runat="server" ControlToValidate="tarikhttxt" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
   <tr>
   <td style="height: 40px; width: 204px;">
       تلفن :</td>
   <td style="height: 40px">
       <asp:TextBox ID="teltxt" runat="server" Width="110px"></asp:TextBox></td>
   </tr>
    <tr>
        <td style="width: 204px; height: 40px">
            آدرس :</td>
        <td style="height: 40px">
            <asp:TextBox ID="addresstxt" runat="server" Width="110px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="addresstxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 204px; height: 40px">
            كد رشته تحصيلي :</td>
        <td style="height: 40px">
            <asp:DropDownList ID="reshtecodeddl" runat="server" Width="136px" DataTextField="Name1" DataValueField="codeReshteh">
</asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 204px; height: 40px">
            كد دوره ورودي &nbsp;:</td>
        <td style="height: 40px">
            &nbsp;<asp:DropDownList ID="dorecodddl" runat="server" Width="136px" DataTextField="codeDoreh" DataValueField="codeDoreh">
            </asp:DropDownList>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator9" runat="server" ControlToValidate="dorecodddl" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
<asp:TextBox ID="TextBox4" runat="server" Width="110px"></asp:TextBox>
