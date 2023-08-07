<%@ Control Language="C#" AutoEventWireup="true" CodeFile="newsmanag.ascx.cs" Inherits="UC_Mang_News_newsmanag" %>
<%@ Register Assembly="AspNetPersianDatePickup" Namespace="AspNetPersianDatePickup" TagPrefix="pcal" %>

<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت خبرها</td>
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
                     <td colspan="5" style="vertical-align: middle">
                         <asp:Label ID="Label1" runat="server" Text="عنوان :    "></asp:Label>
                         &nbsp; &nbsp; &nbsp;
                         <asp:TextBox ID="title" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="تاریخ نمایش از :      "></asp:Label>&nbsp;
                           <pcal:PersianDatePickup ID="spdp" runat="server" OnTextChanged="spdp_TextChanged" PersianDateString="" AutoPostBack="True" ReadOnly="True" ></pcal:PersianDatePickup></td>
                           <td>
                            <asp:Label ID="Label3" runat="server" Text="تا    " Width="13px"></asp:Label>
                            &nbsp;
                            <pcal:PersianDatePickup ID="spdp1" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
                            </td>
                </tr>
             <tr>
                 <td colspan="5" style="vertical-align: middle">
                     &nbsp; &nbsp; &nbsp; &nbsp;</td>
                 <td>
                     <asp:Label ID="Label5" runat="server" Text="تاریخ انقضا از :      "></asp:Label>
                     &nbsp; &nbsp;
                     <pcal:PersianDatePickup ID="epdp" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
      </td>
                 <td>
                     <asp:Label ID="Label6" runat="server" Text="تا    " Width="20px"></asp:Label>
                     &nbsp;
                     <pcal:PersianDatePickup ID="epdp1" runat="server" ReadOnly="True" ></pcal:PersianDatePickup>
      </td>
             </tr>
             <tr>
                 <td colspan="5" style="vertical-align: middle">
                 </td>
                 <td>
                 </td>
                 <td align="center">
                     <asp:Button ID="search" runat="server" Text="جستجو" Width="96px" OnClick="search_Click" /></td>
             </tr>
                
                
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td style="width: 150px; text-align: right">
                                            <asp:Label ID="lblPageName" 
                                            runat="server" Font-Names="Tahoma" 
                                            Font-Size="12px" Text='<%# Eval("title") %>'></asp:Label>
                                        </td>
                                        <td style="width: 150px; text-align: right">
                                            <asp:Label ID="lblsdate" runat="server" 
                                            Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("activeDate") %>'></asp:Label>
                                        </td>
                                        <td style="width: 150px; text-align: right">
                                            <asp:Label ID="lblexpdate" runat="server" 
                                            Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("expDate") %>'></asp:Label>
                                        </td>
                                           <td style="width: 150px; text-align: right">
                                            <a href="../ControlPanel/manag.aspx?page=delnews&id=<%# Eval("id") %>">حذف این خبر </a>
                                        </td>
                                        <td style="width: 150px; text-align: right">
                                            <a href="../ControlPanel/manag.aspx?page=updatenews&id=<%# Eval("id") %>">ویرایش این خبر </a>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <HeaderTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <th style="width: 150px; text-align: right; font-family: Arial; font-size: 16px">
                                          عنوان  
                                        </th>
                                        <th style="width: 150px; text-align: right; font-family: Arial; font-size: 16px">
                                            تاریخ نمایش
                                        </th>
                                        <th style="width: 150px; text-align: right; font-family: Arial; font-size: 16px">
                                            تاریخ انقضا
                                        </th>
                                        <th style="width: 150px; text-align: right; font-family: Arial; font-size: 16px">
                                            حذف
                                        </th>
                                        <th style="width: 150px; text-align: right; font-family: Arial; font-size: 16px">
                                            ویرایش
                                        </th>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <EditItemTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td>
                                        عنوان
                                        </td>
                                        <td align ="center" >
                                            <asp:TextBox ID="tbxPageName" runat="server" Width="325px" Text ='<%# Eval("newsName") %>' ></asp:TextBox>
                                         </td>
                                         <td>
                                         تاریخ نمایش</td>
                                         <td>
                                         <td>
                                         تاریخ انقضا</td>
                                         </tr>
                                    <tr>
                                    <td>
                                    محتوای
                                    </td>
                                    
                                    </tr>
                                </table>
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle Width="100%" />
                    <PagerSettings Mode="NumericFirstLast" />
                    <AlternatingRowStyle BackColor="#C0C0FF" />
                    <HeaderStyle BackColor="GreenYellow" />
                    <EmptyDataTemplate>
          
          <table cellpadding ="0" cellspacing="0" border ="0" background = "./images/backEmpt.gif" width ="80%" >
          <tr style="height:100px">
          <td style ="font-family:Tahoma;font-size:12px">نتیجه ای یافت نشد. 
          </td>
          </tr>
          </table>
           
        </EmptyDataTemplate>
                </asp:GridView>
    </center></td></tr>
</table>
