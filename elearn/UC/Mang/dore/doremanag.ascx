<%@ Control Language="C#" AutoEventWireup="true" CodeFile="doremanag.ascx.cs" Inherits="UC_Mang_dore_doremanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color : Blue
            border-bottom : maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت دوره ها</td>
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
    <tr>
        <td>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%" OnPageIndexChanging="gvPageManag_PageIndexChanging" OnRowCancelingEdit="gvPageManag_RowCancelingEdit" OnRowEditing="gvPageManag_RowEditing" OnRowUpdating="gvPageManag_RowUpdating">
<PagerSettings Mode="NumericFirstLast"></PagerSettings>

<RowStyle Width="100%"></RowStyle>
<Columns>
<asp:TemplateField><EditItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
    <td>
    <asp:Label ID="lblcodedore" runat="server" Font-Names="Tahoma" Font-Size="12px"
        Text='<%# Eval("CodeDoreh") %>'></asp:Label></TD>
        <td align=center><asp:TextBox id="txtterm" Width="325px" runat="server" Text='<%# Eval("term") %>'></asp:TextBox> </TD>
        <td>
            <asp:TextBox ID="txtyear" runat="server" Text='<%#  Eval("year") %>'></asp:TextBox></TD>
            </TR>
            </TBODY></TABLE>
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">
    كد دوره</TH><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">
    ترم</TH>
    <th align="center" style="font-size: 16px; width: 199px; font-family: Arial; text-align: center"
        valign="middle">
        سال</th>
    <TH style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center" align="center" valign="middle">
    &nbsp;حذف</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr>
<td style="WIDTH: 150px; TEXT-ALIGN: right" align="center"><asp:Label id="lblcodedore" runat="server" Text='<%# Eval("CodeDoreh") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
<td style="WIDTH: 150px; TEXT-ALIGN: right" align="center"><asp:Label id="lblterm" runat="server" Text='<%# Eval("term") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
    <td align="center" style="width: 150px; text-align: center">
        <asp:Label ID="lblyear" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("year") %>'></asp:Label></td>
    <td style="WIDTH: 150px; TEXT-ALIGN: center" align="center">
       <a href='../ControlPanel/manag.aspx?page=deletedore&id=<%# Eval("CodeDoreh") %>'>حذف</TD></TR></TBODY></TABLE>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField CancelText="انصراف" EditText="ويرايش" HeaderText="ويرايش" ShowEditButton="True"
        UpdateText="تاييد" />
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
