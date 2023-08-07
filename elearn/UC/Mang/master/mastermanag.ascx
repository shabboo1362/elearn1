<%@ Control Language="C#" AutoEventWireup="true" CodeFile="mastermanag.ascx.cs" Inherits="UC_Mang_master_mastermanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت مدرسان</td>
    </tr>
    <tr style ="height:40px">
        <td colspan="6" style="font-weight: bold; font-size: 16px; vertical-align: middle;
            border-bottom: maroon 2px solid; font-family: Arial">
            <table border="0" cellpadding="5" width="100%">
                <tr>
                    <td style="width: 40px; text-align: center">
                        <asp:Image ID="imSuccess" runat="server" Height="25px" ImageUrl="../../../images/succes.GIF"
                            Visible="false" Width="25px" /></td>
                    <td colspan="5" style="vertical-align: middle">
                        <asp:Label ID="lblMessage" runat="server" Style="font-size: 16px; font-family: Arial"></asp:Label></td>
                </tr>
                
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%" OnRowCancelingEdit="gvPageManag_RowCancelingEdit" OnRowEditing="gvPageManag_RowEditing" OnRowUpdating="gvPageManag_RowUpdating" >
<PagerSettings Mode="NumericFirstLast"></PagerSettings>

<RowStyle Width="100%"></RowStyle>
<Columns>
<asp:TemplateField><EditItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0>
<tbody>
<tr>
 <td style=" text-align: right; height: 38px;">
     <asp:Label ID="codestudent" runat="server" Text='<%# Eval("userCode") %>'></asp:Label>
 </td>
    <td style=" text-align: right; height: 38px;">
        <asp:TextBox ID="name" runat="server" Text='<%# Eval("name") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
        <asp:TextBox ID="family" runat="server" Text='<%# Eval("family") %>'></asp:TextBox></td>
    <td style="text-align: right; height: 38px;">
        <asp:TextBox ID="father" runat="server" Text='<%# Eval("father") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
        <asp:TextBox ID="codeMail" runat="server" Text='<%# Eval("codeMelli") %>'></asp:TextBox></td>
    <td style="TEXT-ALIGN: center; height: 38px;" align="center">
     <asp:TextBox ID="shshenasnameh" runat="server" Text='<%# Eval("shShenasnameh") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
     <asp:TextBox ID="address" runat="server" Text='<%# Eval("address") %>'></asp:TextBox></td>
     <td style="height: 38px">
     <asp:TextBox ID="tel" runat="server" Text='<%# Eval("tel") %>'></asp:TextBox> </td>
     <td style="height: 38px">
     <asp:TextBox ID="reshte" runat="server" Text='<%# Eval("reshteh") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
     <asp:TextBox ID="codereshte" runat="server" Text='<%# Eval("codeRshteh") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
     <asp:TextBox ID="usertype" runat="server" Text='<%# Eval("typeUser") %>'></asp:TextBox></td>
    <td style=" text-align: right; height: 38px;">
     <asp:TextBox ID="lastg" runat="server" Text='<%# Eval("lastGrade") %>'></asp:TextBox></td>
     
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    شماره كاربري</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
   نام</TH>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        نام خانوادگي</th>
    <th style="font-size: 16px; width: 156px; font-family: Arial; height: 19px; text-align: right">
       نام پدر</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        كد ملي</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       ش ش</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
      آدرس</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
      تلفن</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       رشته تحصيلي</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       كد رشته تخصصي</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       نوع كاربر</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       آخرين مدرك تحصيلي</th>
    <th style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center" valign="middle">
    حذف</TH>
    </TR>
    </TBODY>
    </TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0>
<tbody>
<tr>
 <td style=" text-align: right">
        <asp:Label ID="lblcodestudent" runat="server" Text='<%# Eval("userCode") %>'></asp:Label></td>
    <td style=" text-align: right">
        <asp:Label ID="lblname" runat="server" Text='<%# Eval("name") %>'></asp:Label></td>
    <td style=" text-align: right">
        <asp:Label ID="lblfamily" runat="server" Text='<%# Eval("family") %>'></asp:Label></td>
    <td style="text-align: right">
        <asp:Label ID="lblfather" runat="server" Text='<%# Eval("father") %>'></asp:Label></td>
    <td style=" text-align: right">
        <asp:Label ID="lblcodeMail" runat="server" Text='<%# Eval("codeMelli") %>'></asp:Label></td>
    <td style="TEXT-ALIGN: center" align="center">
     <asp:Label ID="lblshshenasnameh" runat="server" Text='<%# Eval("shShenasnameh") %>'></asp:Label></td>
    <td style=" text-align: right">
     <asp:Label ID="lbladdress" runat="server" Text='<%# Eval("address") %>'></asp:Label></td>
     <td>
     <asp:Label ID="lbltel" runat="server" Text='<%# Eval("tel") %>'></asp:Label> </td>
     <td>
     <asp:Label ID="lblreshtet" runat="server" Text='<%# Eval("reshteh") %>'></asp:Label></td>
    <td style=" text-align: right">
     <asp:Label ID="lblcodereshte" runat="server" Text='<%# Eval("codeRshteh") %>'></asp:Label></td>
    <td style=" text-align: right">
     <asp:Label ID="lblusertype" runat="server" Text='<%# Eval("typeUser") %>'></asp:Label></td>
    <td style=" text-align: right">
     <asp:Label ID="lbllastg" runat="server" Text='<%# Eval("lastGrade") %>'></asp:Label></td>
     <td style=" text-align: right">
    <a href="../ControlPanel/manag.aspx?page=delmaster&id=<%# Eval("userCode") %>">حذف  </a></td>
    </TR></TBODY></TABLE>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField CancelText="انصراف" EditText="ويرايش" ShowEditButton="True" UpdateText="تاييد" />
</Columns>
<EmptyDataTemplate>
          
          <table cellpadding ="0" cellspacing="0" border ="0" background = "./images/backEmpt.gif" width ="80%" >
          <tr style="height:100px">
          <td style ="font-family:Tahoma;font-size:12px">نتیجه ای یافت نشد. 
          </td>
          </tr>
          </table>
           
        
</EmptyDataTemplate>

<HeaderStyle BackColor="GreenYellow"></HeaderStyle>

<AlternatingRowStyle BackColor="#C0C0FF"></AlternatingRowStyle>
</asp:GridView>
    </center></td></tr>
</table>
