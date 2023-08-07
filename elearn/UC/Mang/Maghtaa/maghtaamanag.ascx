<%@ Control Language="C#" AutoEventWireup="true" CodeFile="maghtaamanag.ascx.cs" Inherits="UC_Mang_Maghtaa_maghtaamanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت مقاطع تحصيلي</td>
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
<td style="height: 19px">
    <asp:Label ID="lblnamemaghtaa" runat="server" Font-Names="Tahoma" Font-Size="12px"
        Text='<%# Eval("nameMaghtaa") %>'></asp:Label>
</TD>
    <td style="height: 19px">
        <asp:TextBox ID="minvahed" runat="server" Text='<%# Eval("minVahed") %>'></asp:TextBox></td>
    <td style="height: 19px"> 
        <asp:TextBox ID="moadela" runat="server" Text='<%# Eval("MoaadelA") %>'></asp:TextBox></TD>
        <td style="height: 19px; width: 199px;">
        <asp:TextBox ID="moadelm" runat="server" Text='<%# Eval("MoaadelMashroti") %>'></asp:TextBox></TD>
        <td style="height: 19px;">
        <asp:TextBox ID="maxvahedm" runat="server" Text='<%# Eval("maxVahedM") %>'></asp:TextBox></TD>
        <td style="height: 19px;">
        <asp:TextBox ID="maxvaheda" runat="server" Text='<%# Eval("maxVahedA") %>'></asp:TextBox></TD>
        <td style="height: 19px; width: 157px;">
        <asp:TextBox ID="maxvahedg" runat="server" Text='<%# Eval("maxVahedG") %>' Width="155px"></asp:TextBox></TD>
        <td></td>
        </TR>
        </TBODY>
        </TABLE>
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;" align="center">
    نام مقطع</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    حداقل واحد</TH>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right" align="center">
        معدل A</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right" align="center">
        معدل مشروطي</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        سقف واحد مشروطي</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        سقف واحد معدل A</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        سقف واحد حالت عادي</th>
    <th style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center" valign="middle">
    حذف</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblnamemaghtaa" runat="server" Text='<%# Eval("nameMaghtaa") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblminvahed" runat="server" Text='<%# Eval("minVahed") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmoadela" runat="server" Text='<%# Eval("MoaadelA") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmoadelm" runat="server" Text='<%# Eval("MoaadelMashroti") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmaxvm" runat="server" Text='<%# Eval("maxVahedM") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmaxva" runat="server" Text='<%# Eval("maxVahedA") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblmaxvg" runat="server" Text='<%# Eval("maxVahedG") %>'></asp:Label></td>
    <td style="WIDTH: 150px; TEXT-ALIGN: center" align="center">
    <a href="../ControlPanel/manag.aspx?page=deletemaghtaa&id=<%# Eval("nameMaghtaa") %>">حذف  </a>
    </TD>
    </TR>
    </TBODY>
    </TABLE>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField CancelText="انصراف" EditText="ويرايش" ShowEditButton="True" UpdateText="تاييد" HeaderText="ويرايش" />
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
