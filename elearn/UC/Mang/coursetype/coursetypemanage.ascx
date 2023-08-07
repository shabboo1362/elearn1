<%@ Control Language="C#" AutoEventWireup="true" CodeFile="coursetypemanage.ascx.cs" Inherits="UC_Mang_coursetype_coursetypemanage" %>
&nbsp;<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت نوع درس</td>
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
    <td style="height: 59px">
         <table border="0" cellpadding="5" width="100%">
                <tr>
                     <td colspan="1" style="width: 87px">
                         <asp:Label ID="Label1" runat="server" Text="دوره تحصيلي : "></asp:Label></td>
                    <td style="height: 34px">
                        &nbsp;
                        <asp:dropdownlist id="dorecodeddl" runat="server" width="138px" DataTextField="CodeDoreh" DataValueField="CodeDoreh"></asp:dropdownlist>
                    </td>
                    <td style="width: 206px; height: 34px">
                        &nbsp;<asp:button id="searchbtn" runat="server" text="جستجو" width="120px" OnClick="searchbtn_Click" />&nbsp;
                    </td>
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
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td style="height: 24px"> </TD><td align=center style="width: 8px; height: 24px">
    <asp:TextBox ID="txtcoursetype" runat="server" Text='<%# Eval("corseType") %>'></asp:TextBox>&nbsp;</TD><td style="height: 24px">
    <asp:TextBox ID="txttuition" runat="server" Text='<%# Eval("coursTuition") %>'></asp:TextBox></TD><td style="height: 24px"></TD><td style="height: 24px"></TD></TR></TBODY></TABLE>
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">
    نوع درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">
    شهريه واحد در آن دوره</TH><th style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center" align="center" valign="middle">
    &nbsp;حذف</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursetype" runat="server" Text='<%# Eval("corseType") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursetuition" runat="server" Text='<%# Eval("coursTuition") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><td style="WIDTH: 150px; TEXT-ALIGN: center" align="center">
    <a href='../ControlPanel/manag.aspx?page=deletetype&id=<%# Eval("corseType") %>'>حذف </TD></TR></TBODY></TABLE>
</ItemTemplate>
</asp:TemplateField>
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
