<%@ Control Language="C#" AutoEventWireup="true" CodeFile="studentmanag.ascx.cs" Inherits="UC_Mang_student_studentmanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت دانشجويان</td>
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
<asp:TemplateField>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    شماره دانشجويي</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
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
      ت ت</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
      تلفن</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       آدرس</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
      كد رشته</th>
       <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
       كد دوره</th>
    <th style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center" valign="middle">
   حذف</TH>
    </TR>
    </TBODY>
    </TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblcodestudent" runat="server" Text='<%# Eval("codeStudent") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblname" runat="server" Text='<%# Eval("name") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblfamily" runat="server" Text='<%# Eval("family") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblfather" runat="server" Text='<%# Eval("father") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblcodeMail" runat="server" Text='<%# Eval("codeMelli") %>'></asp:Label></td>
    <td style="WIDTH: 150px; TEXT-ALIGN: center" align="center">
     <asp:Label ID="lblshshenasnameh" runat="server" Text='<%# Eval("shShenasnameh") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
     <asp:Label ID="lbltarkht" runat="server" Text='<%# Eval("tarkhT") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
     <asp:Label ID="lblcodeRshteh" runat="server" Text='<%# Eval("codeRshteh") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
     <asp:Label ID="lbltel" runat="server" Text='<%# Eval("tel") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
     <asp:Label ID="lbladdress" runat="server" Text='<%# Eval("address") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
     <asp:Label ID="lblcodeDore" runat="server" Text='<%# Eval("codeDoreh") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
    <a href="../ControlPanel/manag.aspx?page=deletestudent&id=<%# Eval("codeStudent") %>">حذف  </a></td>
    </TR>
    </TBODY>
    </TABLE>
</ItemTemplate>
<EditItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:Label ID="lblcodestudent" runat="server" Text='<%# Eval("codeStudent") %>'></asp:Label>
    </td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:TextBox ID="name" runat="server" Text='<%# Eval("name") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:TextBox ID="family" runat="server" Text='<%# Eval("family") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:TextBox ID="father" runat="server" Text='<%# Eval("father") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:TextBox ID="codeMail" runat="server" Text='<%# Eval("codeMelli") %>'></asp:TextBox></td>
    <td style="WIDTH: 150px; TEXT-ALIGN: center; height: 24px;" align="center">
     <asp:TextBox ID="shshenasnameh" runat="server" Text='<%# Eval("shShenasnameh") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
     <asp:TextBox ID="tarikht" runat="server" Text='<%# Eval("tarkhT") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:Label ID="lblcodeReshteh" runat="server" Text='<%# Eval("codeRshteh") %>'></asp:Label>
    </td>
    <td style="width: 150px; text-align: right; height: 24px;">
     <asp:TextBox ID="tel" runat="server" Text='<%# Eval("tel") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
     <asp:TextBox ID="address" runat="server" Text='<%# Eval("address") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right; height: 24px;">
        <asp:Label ID="lblcodeDore" runat="server" Text='<%# Eval("codeDoreh") %>'></asp:Label>
    </td>
    </EditItemTemplate>
</asp:TemplateField>
    <asp:CommandField EditText="ويرايش" ShowEditButton="True" CancelText="انصراف" HeaderText="ويرايش" UpdateText="ويرايش" />
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
