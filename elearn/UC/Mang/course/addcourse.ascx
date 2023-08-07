<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addcourse.ascx.cs" Inherits="UC_Mang_course_addcourse" %>
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
    كد رشته :</td>
<td align ="right" ><asp:DropDownList ID="reshtecodeddl" runat="server" Width="136px" DataValueField="codeReshteh" DataTextField="Name1">
</asp:DropDownList></td>
</tr>
<tr>
<td>
    نوع درس :</td>
<td align ="right" dir="rtl" colspan="5" ><asp:DropDownList ID="coursetypeddl" runat="server" Width="134px" DataValueField="corseType" DataTextField="Name1">
</asp:DropDownList>&nbsp;
</td>
</tr>
    <tr>
        <td>
            كد درس :</td>
        <td align="right">
            <asp:TextBox ID="coursecodetxt" runat="server" Width="161px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="coursecodetxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>
            نام درس :</td>
        <td align="right">
            <asp:TextBox ID="coursenametxt" runat="server" Width="161px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="coursenametxt"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>
            تعداد واحد نظري :</td>
        <td align="right" style="height: 22px">
            <asp:TextBox ID="nunittxt" runat="server" Width="110px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            تعداد واحد عملي :</td>
        <td align="right">
            <asp:TextBox ID="aunittxt" runat="server" Width="110px"></asp:TextBox></td>
    </tr>
   <tr>
   <td style="height: 40px"><asp:Label ID="Label7" runat="server" Text="نمره قبولي :"></asp:Label></td>
   <td style="height: 40px">
       <asp:TextBox ID="passgreadtxt" runat="server" Width="110px"></asp:TextBox></td>
   </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
