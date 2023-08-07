<%@ Control Language="C#" AutoEventWireup="true" CodeFile="pishmanag.ascx.cs" Inherits="UC_Mang_coursepish_pishmanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت پيش نيازها</td>
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
                         <asp:Label ID="Label1" runat="server" Text="نام / كد درس :"></asp:Label></td>
                    <td style="height: 34px">
                        &nbsp;
                        <asp:dropdownlist id="coursecodeddl" runat="server" width="138px" DataTextField="Name1" DataValueField="courseCode"></asp:dropdownlist>
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
            دروس (پيش نياز و هم نياز) مرتبط با درس &nbsp; &nbsp;
            <asp:label id="Label2" runat="server" text="Label"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <table border="0" cellpadding="5" width="100%">
                <tr>
                    <td align="right">
                        <asp:label id="Label3" runat="server" text="نام / كد درس :"></asp:label>
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;<asp:dropdownlist id="coursecode" runat="server" width="138px" DataTextField="Name1" DataValueField="courseCode"></asp:dropdownlist></td>
                    <td style="height: 34px">
                        نوع:</td>
                    <td style="height: 34px">
                        <asp:dropdownlist id="typeddl" runat="server" width="138px">
                            <asp:ListItem Value="0">پيش نياز</asp:ListItem>
                            <asp:ListItem Value="1">هم نياز</asp:ListItem>
                        </asp:dropdownlist>
                    </td>
                    <td style="width: 206px; height: 34px">
                        &nbsp;<asp:button id="addbtn" runat="server" text="اضافه" width="120px" OnClick="addbtn_Click" />&nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%" OnRowDeleting="gvPageManag_RowDeleting">
<PagerSettings Mode="NumericFirstLast"></PagerSettings>

<RowStyle Width="100%"></RowStyle>
<Columns>
<asp:TemplateField>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody>
<tr><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">نام درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; 
FONT-FAMILY: Arial; TEXT-ALIGN: right">كد درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: right">نوع(پيش نياز / هم نياز)&nbsp;
</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td style="WIDTH: 150px; TEXT-ALIGN: right">
<asp:Label id="lblcoursename" runat="server" Text='<%# Eval("coursName") %>' Font-Size="12px" Font-Names="Tahoma">
</asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursecode" runat="server" Text='<%# Eval("coursePishCode") %>' 
Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lbltype" runat="server" 
Text='<%# Eval("type") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
</TR></TBODY></TABLE>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="حذف " HeaderText="حذف" />
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
