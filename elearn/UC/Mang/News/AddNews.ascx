<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddNews.ascx.cs" Inherits="UC_Mang_News_AddNews" %>
<%@ Register TagPrefix="ftb" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<%@ Register Assembly="AspNetPersianDatePickup" Namespace="AspNetPersianDatePickup" TagPrefix="pcal" %>

<table dir ="rtl"  style="width: 95%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       تعریف خبر جدید</td>
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
عنوان
</td>
<td align ="right" >
    <asp:TextBox ID="title" runat="server" Width="325px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="title"
        ErrorMessage="فیلدهای ستاره دار را وارد کنید.">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
<td>
محتوای
</td>
<td align ="center" dir="rtl" colspan="5" >
<center>
<FTB:FreeTextBox id="FTBText" runat="Server" toolbarlayout="FontFacesMenu,FontSizesMenu,FontForeColorsMenu,Bold,Italic,Underline
        ,JustifyLeft,JustifyRight,JustifyCenter,JustifyFull,BulletedList,NumberedList,Indent,
		Outdent,CreateLink,Unlink,InsertImage,Cut,Copy,Paste,Delete;Undo,Redo,SymbolsMenu,
		,InsertRule,InsertDate,InsertTime,InsertTable,InsertImageFromGallery," TextDirection="RightToLeft" 
		ImageGalleryPath="~/IMG/" Width ="90%" Language="fa-IR" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="title"
        ErrorMessage="فیلدهای ستاره دار را وارد کنید.">*</asp:RequiredFieldValidator></center>
</td>
</tr>
<tr>
 <td><asp:Label ID="Label4" runat="server" Text=" الویت : "></asp:Label></td>
   <td align="right"> <asp:TextBox ID="olaviat" runat="server" ></asp:TextBox>
       <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="olaviat"
           MaximumValue="255" MinimumValue="0">عددی بین 0 تا 256 را وارد کنید.</asp:RangeValidator></td>
    </tr>
    <tr>
  <td style="height: 26px">  <asp:Label ID="Label5" runat="server" Text="تاریخ نمایش : "></asp:Label></td>
   <td style="height: 26px"><pcal:PersianDatePickup ID="pdp" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
       </td>
    </tr>
    <tr>
    <td><asp:Label ID="Label6" runat="server" Text="تاریخ انقضا : "></asp:Label></td>
    <td><pcal:PersianDatePickup ID="pdp2" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
        </td> 
   </tr>
   <tr>
   <td style="height: 40px"><asp:Label ID="Label7" runat="server" Text="تصویر خبر : "></asp:Label></td>
   <td style="height: 40px"><asp:FileUpload ID="FileUpload1" runat="server" />
       </td>
   </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="محل درج خبر : "></asp:Label></td>
        <td>
            <asp:DropDownList ID="reshteddl" runat="server">
                <asp:ListItem Selected="True" Value="0">صفحه اصلی</asp:ListItem>
            </asp:DropDownList></td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
