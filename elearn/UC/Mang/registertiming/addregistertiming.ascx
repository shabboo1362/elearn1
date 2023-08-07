<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addregistertiming.ascx.cs" Inherits="UC_Mang_registertiming_addregistertiming" %>
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
    style ="font-family:Arial ;font-size:16px; font-weight:bold ;"></asp:Label>&nbsp;&nbsp;
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td style="width: 177px">
    دوره :</td>
<td align ="right" ><asp:DropDownList ID="dorecodeddl" runat="server" Width="136px" DataTextField="CodeDoreh" DataValueField="CodeDoreh">
</asp:DropDownList></td>
</tr>
<tr>
<td style="width: 177px">
    ورودي :</td>
<td align ="right" dir="rtl" colspan="5" ><asp:DropDownList ID="vorodiddl" runat="server" Width="134px" DataTextField="CodeDoreh" DataValueField="CodeDoreh">
</asp:DropDownList>&nbsp;
</td>
</tr>
    <tr>
        <td style="width: 177px; height: 31px">
            تاريخ شروع انتخاب واحد :</td>
        <td align="right" style="height: 31px">
            <pcal:PersianDatePickup ID="rbeginpdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>&nbsp;<asp:RequiredFieldValidator
                ID="RequiredFieldValidator5" runat="server" ControlToValidate="rbeginpdp" ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 177px">
            تاريخ پايان انتخاب واحد :</td>
        <td align="right">
            <pcal:PersianDatePickup ID="rexppdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="rbeginpdp"
                ControlToValidate="rexppdp" ErrorMessage="تاريخ پايان انتخاب واحد نبايد از تاريخ شروع انتخاب واحد كوچكتر باشد."
                Operator="GreaterThan">*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rexppdp"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 31px">
            تاريخ شروع حذف و اضافه :</td>
        <td align="right" style="height: 31px">
            <pcal:PersianDatePickup ID="arbegindpdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="rexppdp"
                ControlToValidate="arbegindpdp" ErrorMessage="تاريخ شروع حذف و اضافه نبايد از تاريخ پايان  انتخاب واحد كوچكتر باشد."
                Operator="GreaterThan">*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="arbegindpdp"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 44px">
            تاريخ پايان حذف و اضافه :</td>
        <td align="right" style="height: 44px">
            <pcal:PersianDatePickup ID="arexppdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="arbegindpdp"
                ControlToValidate="arexppdp" ErrorMessage="تاريخ پايان حذف و اضافه نبايد از تاريخ شرحذف و اضافه  كوچكتر باشد."
                Operator="GreaterThan">*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="arexppdp"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
   <tr>
   <td style="height: 40px; width: 177px;">
       تاريخ شروع حذف اضطراري :</td>
   <td style="height: 40px">
       <pcal:PersianDatePickup ID="erbeginpdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>
       <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToCompare="arexppdp"
           ControlToValidate="erbeginpdp" ErrorMessage="تاريخ شروع حذف اضطراري نبايد از تاريخ پايان حذف و اضافه كوچكتر باشد."
           Operator="GreaterThan">*</asp:CompareValidator>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="erbeginpdp"
           ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
   </tr>
    <tr>
        <td style="width: 177px; height: 40px">
            تاريخ پايان حذف اضطراري :</td>
        <td style="height: 40px">
            <pcal:PersianDatePickup ID="erexppdp" runat="server" ReadOnly="True"></pcal:PersianDatePickup>
            <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToCompare="erbeginpdp"
                ControlToValidate="erexppdp" ErrorMessage="تاريخ پايان حذف اضطراري نبايد از تاريخ شروع آن كوچكتر باشد."
                Operator="GreaterThan">*</asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="erexppdp"
                ErrorMessage="فيلدهاي ستاره دار را وارد كنيد.">*</asp:RequiredFieldValidator></td>
    </tr>
<tr>
<td align ="center" colspan="6" >
   <center><asp:Button ID="btnSubmit" runat="server" Text="تایید " 
    Font-Names="Courier New" Font-Size="12pt"  OnClientClick="displayFun();" OnClick="btnSubmit_Click" />&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   />  </center></td>
</tr>
</table>
