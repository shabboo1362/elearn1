<%@ Control Language="C#" AutoEventWireup="true" CodeFile="reshtemanag.ascx.cs" Inherits="UC_Mang_reshte_reshtemanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت رشته هاي تحصيلي</td>
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
<asp:TemplateField><EditItemTemplate><table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
<td style="WIDTH: 150px; TEXT-ALIGN: right">
    <asp:Label ID="lblreshte" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("codeReshteh") %>'></asp:Label>&nbsp;
</TD>
<td style="WIDTH: 150px; TEXT-ALIGN: right">
<asp:TextBox id="namereshte" runat="server" Text='<%# Eval("name") %>' Font-Size="12px" Font-Names="Tahoma"></asp:TextBox> </TD>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmaghtaname" runat="server" Text='<%# Eval("nameMaghtaa") %>'></asp:Label>
    </td>
    <td style="width: 150px; text-align: right">
        <asp:TextBox ID="vomomi" runat="server" Text='<%# Eval("vahedOmomi") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right">
        <asp:TextBox ID="vtz" runat="server" Text='<%# Eval("vahedTZ") %>'></asp:TextBox></td>
    <td style="width: 150px; text-align: right">
        <asp:TextBox ID="vte" runat="server" Text='<%# Eval("vahedTE") %>'></asp:TextBox></td>
        
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    كد رشته</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    نام رشته</TH>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        نام دوره</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        تعداد واحد عمومي</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        واحدهاي تخصصي ضروري</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        واحدهاي تخصصي اختياري</th>
    <th style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center" valign="middle">
    &nbsp;حذف</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
<td style="WIDTH: 150px; TEXT-ALIGN: right">
<asp:Label id="lblcodereshte" runat="server" Text='<%# Eval("codeReshteh") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
<td style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblnamereshte" runat="server" Text='<%# Eval("name") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmaghtaname" runat="server" Text='<%# Eval("nameMaghtaa") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblvomomi" runat="server" Text='<%# Eval("vahedOmomi") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblvtz" runat="server" Text='<%# Eval("vahedTZ") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblvte" runat="server" Text='<%# Eval("vahedTE") %>'></asp:Label></td>
    <td style="WIDTH: 150px; TEXT-ALIGN: center" align="center">
     <a href="../ControlPanel/manag.aspx?page=deletereshte&id=<%# Eval("codeReshteh") %>">حذف  </a></td>
</tr>
</tbody>
</table>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField EditText="ويرايش" ShowEditButton="True" CancelText="انصراف" HeaderText="ويرايش" UpdateText="تاييد" />
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
