<%@ Control Language="C#" AutoEventWireup="true" CodeFile="tuitionmanag.ascx.cs" Inherits="UC_Mang_tuition_tuitionmanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت ارائه دروس</td>
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
         <table border="0" cellpadding="5" width="100%">
                <tr>
                     <td colspan="5" align="right" dir="rtl">
                         <asp:Label ID="Label1" runat="server" Text="كد دوره :" Width="48px"></asp:Label></td>
                        <td style="width: 165px; height: 34px" align="right" dir="ltr">
                            <asp:DropDownList ID="codedoreddl" runat="server" Width="102px" DataTextField="CodeDore" DataValueField="CodeDore">
                            </asp:DropDownList></td>
                           <td style="width: 72px; height: 34px" align="right" dir="rtl">
                               <asp:Label ID="Label2" runat="server" Text="كد درس :" Width="55px"></asp:Label></td>
                    <td align="right" dir="rtl" style="width: 30px; height: 34px">
                        <asp:DropDownList ID="coursecodeddl" runat="server" DataTextField="Name" DataValueField="courseCode">
                        </asp:DropDownList></td>
                    <td align="center" dir="rtl" style="height: 34px">
                     <asp:Button ID="search" runat="server" Text="جستجو" Width="96px" OnClick="search_Click" /></td>
                </tr>
                
                
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
        <asp:GridView ID="gvPageManag" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            OnRowCancelingEdit="gvPageManag_RowCancelingEdit" OnRowEditing="gvPageManag_RowEditing"
            OnRowUpdating="gvPageManag_RowUpdating" OnSelectedIndexChanging="gvPageManag_SelectedIndexChanging"
            PageSize="15" RowStyle-Width="100%" Width="100%">
            <PagerSettings Mode="NumericFirstLast" />
            <RowStyle Width="100%" />
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        </table>
                            <tbody>
                            </tbody>
                                <tr>
                                </tr>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="codereshte" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("codeReshte") %>'></asp:Label>&nbsp;
                                    </td>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="codedore" runat="server" Font-Names="Tahoma" Font-Size="12px"
                                            Text='<%# Eval("CodeDoreh") %>'></asp:Label>
                                    </td>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="codedoreinput" runat="server" Text='<%# Eval("CodeDorehInput") %>'></asp:Label>
                                    </td>
                                    
                                    <td style="width: 150px; text-align: right">
                                        <asp:TextBox ID="tuition" runat="server" Text='<%# Eval("tuition") %>'></asp:TextBox></td>
                                   
                    </EditItemTemplate>
                    <HeaderTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tbody>
                                <tr>
                                    <th style="font-size: 16px; width: 150px; font-family: Arial; text-align: right;
                                        height: 19px;">
                                       دوره</th>
                                    <th style="font-size: 16px; width: 150px; font-family: Arial; text-align: right;
                                        height: 19px;">
                                       ورودي</th>
                                    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                        كد رشته</th>
                                    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                       شهريه</th>
                                    
                                    <th align="center" style="font-size: 16px; width: 199px; font-family: Arial; text-align: center;
                                        height: 19px;" valign="middle">
                                        &nbsp;حذف</th>
                                </tr>
                            </tbody>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tbody>
                                <tr>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="lblcodereshte" runat="server" Font-Names="Tahoma" Font-Size="12px"
                                            Text='<%# Eval("CodeDoreh") %>'></asp:Label>
                                    </td>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="lblnamereshte" runat="server" Font-Names="Tahoma" Font-Size="12px"
                                            Text='<%# Eval("CodeDorehInput") %>'></asp:Label>
                                    </td>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="lblmaghtaname" runat="server" Text='<%# Eval("codeReshteh") %>'></asp:Label></td>
                                    <td style="width: 150px; text-align: right">
                                        <asp:Label ID="lblvomomi" runat="server" Text='<%# Eval("tuition") %>'></asp:Label></td>
                                    <td align="center" style="width: 150px; text-align: center">
                                        <a href='../ControlPanel/manag.aspx?page=delreshte&id=<%# Eval("CodeDoreh") %>'>حذف
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField EditText="ويرايش" ShowEditButton="True" />
            </Columns>
            <EmptyDataTemplate>
                <table background="./images/backEmpt.gif" border="0" cellpadding="0" cellspacing="0"
                    width="80%">
                    <tr style="height: 100px">
                        <td style="font-family: Tahoma; font-size: 12px">
                            نتیجه ای یافت نشد. 
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <HeaderStyle BackColor="GreenYellow" />
            <AlternatingRowStyle BackColor="#C0C0FF" />
        </asp:GridView>
        &nbsp;</center></td></tr>
</table>
