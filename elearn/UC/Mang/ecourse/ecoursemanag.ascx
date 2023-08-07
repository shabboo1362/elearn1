<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ecoursemanag.ascx.cs" Inherits="UC_Mang_ecourse_ecoursemanag" %>
<%@ Register Assembly="AspNetPersianDatePickup" Namespace="AspNetPersianDatePickup" TagPrefix="pcal" %>
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
                            <asp:DropDownList ID="codedoreddl" runat="server" Width="102px" DataTextField="CodeDoreh" DataValueField="CodeDoreh">
                            </asp:DropDownList></td>
                           <td style="width: 72px; height: 34px" align="right" dir="rtl">
                               <asp:Label ID="Label2" runat="server" Text="كد درس :" Width="55px"></asp:Label></td>
                    <td align="right" dir="rtl" style="width: 30px; height: 34px">
                        <asp:DropDownList ID="coursecodeddl" runat="server" DataTextField="Name1" DataValueField="courseCode">
                        </asp:DropDownList></td>
                    <td align="center" dir="rtl" style="height: 34px">
                     <asp:Button ID="search" runat="server" Text="جستجو" Width="96px" OnClick="search_Click" /></td>
                </tr>
                
                
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="5" RowStyle-Width="100%" Width="100%" OnPageIndexChanging="gvPageManag_PageIndexChanging" OnRowCancelingEdit="gvPageManag_RowCancelingEdit" OnRowEditing="gvPageManag_RowEditing" OnRowUpdating="gvPageManag_RowUpdating">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                            <table>
                            <tr>
                                <td style="width: 20%;">
                                <asp:Label ID="Label3" runat="server" Text="نام درس :"></asp:Label>
                                </td>
                                <td style="width: 20%;">
                                <asp:Label ID="name" runat="server" Text='<%# Eval("coursName") %>'></asp:Label></td>
                                <td style="width: 20%;">
                                <asp:Label ID="coursecode" runat="server" Text="كد درس :"></asp:Label>
                                 </td>
                                <td style="width: 20%;">
                                <asp:Label ID="ccode" runat="server" Text='<%# Eval("courseCode") %>'></asp:Label>
                                
                                </td>                                
                                <td style="width: 20%;" align="center">
                                     <a href="../ControlPanel/manag.aspx?page=deleteecourse&id=<%# Eval("id") %>">  حذف</a>
                                </td>
                            </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label4" runat="server" Text="كد دوره:"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="Label11" runat="server"
                                    Text='<%# Eval("codeDoreh") %>'></asp:Label></td>
                                    <td style="width: 20%">
                                 شعبه : <asp:Label ID="Label7" runat="server" Text='<%# Eval("branche") %>'></asp:Label></td>
                                   
                                    <td style="width: 100">
                                   
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label8" runat="server" Text="ظرفيت :"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="capacity" runat="server" Text='<%# Eval("capacity") %>'></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="Label9" runat="server" Text="كد مدرس :"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="mastercode" runat="server" Text='<%# Eval("masterCode") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label10" runat="server" Text="تاريخ امتحان :"></asp:Label></td>
                                    <td style="width: 20%">
                                    <asp:Label ID="examdate" runat="server" Text='<%# Eval("examDate") %>'></asp:Label></td>
                                    <td style="width: 20%">
                                        <asp:Label ID="Label6" runat="server" Text="ساعت امتحان"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="examtime" runat="server" Text='<%# Eval("examTime") %>'></asp:Label></td>
                                    <td style="width: 20%" align="center">
                                    </td>
                                </tr>
                            </table>
                            </ItemTemplate>
                            
                            <EditItemTemplate>
                                <table>
                            <tr>
                                <td style="width: 20%;">
                                <asp:Label ID="Label3" runat="server" Text="نام درس :"></asp:Label>
                                </td>
                                <td style="width: 20%;">
                                <asp:Label ID="name" runat="server" Text='<%# Eval("coursName") %>'></asp:Label></td>
                                <td style="width: 20%;">
                                <asp:Label ID="coursecode" runat="server" Text="كد درس :"></asp:Label>
                                 </td>
                                <td style="width: 20%;">
                                <asp:Label ID="ccode" runat="server" Text='<%# Eval("courseCode") %>'></asp:Label>
                                
                                </td>                                
                            </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label4" runat="server" Text="كد دوره:"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="dcode" runat="server"
                                    Text='<%# Eval("codeDoreh") %>'></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:Label ID="Label7" runat="server" Text="شعبه :"></asp:Label></td>
                                    
                                </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label8" runat="server" Text="ظرفيت :"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:TextBox ID="capacity" runat="server" Text='<%# Eval("capacity") %>'></asp:TextBox></td>
                                    <td style="width: 20%">
                                <asp:Label ID="Label9" runat="server" Text="كد مدرس :"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:TextBox ID="mastercode" runat="server" Text='<%# Eval("masterCode") %>'></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 20%">
                                <asp:Label ID="Label10" runat="server" Text="تاريخ امتحان :"></asp:Label></td>
                                    <td style="width: 20%">
                                    <asp:TextBox ID="examdate" runat="server" Text='<%# Eval("examDate") %>'></asp:TextBox></td>
                                    <td style="width: 20%">
                                        <asp:Label ID="Label6" runat="server" Text="ساعت امتحان"></asp:Label></td>
                                    <td style="width: 20%">
                                <asp:TextBox ID="examtime" runat="server" Text='<%# Eval("examTime") %>'></asp:TextBox></td>
                                <td style="width: 20%">
                                <asp:Label  ID="lblID" runat="server" Text='<%# Eval("id") %>' Visible ="false" ></asp:Label></td>
                                </tr>
                            </table>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField EditText="ويرايش" ShowEditButton="True" CancelText="انصراف" HeaderText="ويرايش" UpdateText="تاييد" />
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
