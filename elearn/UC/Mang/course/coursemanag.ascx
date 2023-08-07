<%@ Control Language="C#" AutoEventWireup="true" CodeFile="coursemanag.ascx.cs" Inherits="UC_Mang_course_coursemanag" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue;
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
                     <td colspan="5" style="vertical-align: middle; width: 61px; height: 34px;" align="right" dir="rtl">
                         <asp:Label ID="Label1" runat="server" Text="كد رشته :"></asp:Label>
                         &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                     </td>
                        <td style="width: 170px; height: 34px" align="right" dir="ltr">
                            <asp:DropDownList ID="codereshteddl" runat="server" Width="102px" DataTextField="Name1" DataValueField="codeReshteh">
                            </asp:DropDownList></td>
                           <td style="width: 72px; height: 34px" align="right" dir="rtl">
                               <asp:Label ID="Label2" runat="server" Text="كد درس :"></asp:Label></td>
                    <td align="right" dir="rtl" style="width: 30px; height: 34px">
                        <asp:TextBox ID="coursecodetxt" runat="server" Width="106px"></asp:TextBox></td>
                    <td align="center" dir="rtl" style="height: 34px">
                     <asp:Button ID="search" runat="server" Text="جستجو" Width="96px" OnClick="search_Click" /></td>
                </tr>
                
                
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%"  OnPageIndexChanging="gvPageManag_PageIndexChanging" OnRowCancelingEdit="gvPageManag_RowCancelingEdit" OnRowEditing="gvPageManag_RowEditing" OnRowUpdating="gvPageManag_RowUpdating">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                            <table><tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="نام درس :"></asp:Label>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                </td>
                                <td><asp:Label ID="name" runat="server" Text='<%# Eval("coursName") %>'></asp:Label>
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:Label ID="coursecode" runat="server" Text="كد درس :"></asp:Label>
                                    &nbsp; &nbsp;&nbsp;</td>
                                <td >
                                <asp:Label ID="ccode" runat="server" Text='<%# Eval("courseCode") %>'></asp:Label></td>
                                <td>
                                </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="كد رشته :"></asp:Label></td>
                                    <td >
                                <asp:Label ID="rcode" runat="server" Text='<%# Eval("codeReshteh") %>'></asp:Label></td>
                                    <td>
                                    </td>
                               <td>
                                </td>
                                    <td align="center"  >
                                         <a href='../ControlPanel/manag.aspx?page=delcourse&id=<%# Eval("courseCode") %>'>حذف 
                                    </td>
                                        
                                        
                                </tr>
                                <tr>
                                    <td style="height: 40px">
                                <asp:Label ID="Label7" runat="server" Text="نمره قبولي :"></asp:Label></td>
                                    <td >
                                      <asp:Label ID="passgread" runat="server"
                                    Text='<%# Eval("passGread") %>'></asp:Label></td>
                                    <td style=" height: 40px">
                                <asp:Label ID="Label8" runat="server" Text="نوع درس :"></asp:Label></td>
                                    <td style="height: 40px; ">
                                <asp:Label ID="type" runat="server" Text='<%# Eval("corseType") %>'></asp:Label></td>
                                    <td style=" height: 40px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 40px">
                                <asp:Label ID="Label9" runat="server" Text="تعداد واحد نظري :"></asp:Label></td>
                                    <td style=" height: 40px">
                                        <asp:Label ID="nunit" runat="server" Text='<%# Eval("nUnit") %>'></asp:Label></td>
                                    <td style=" height: 40px">
                                <asp:Label ID="Label10" runat="server" Text="تعداد واحد عملي :"></asp:Label>
                                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    </td>
                                    <td style="height: 40px;">
                                <asp:Label ID="aunit" runat="server" Text='<%# Eval("aUnit") %>'></asp:Label></td>
                                    <td style=" height: 40px">
                                    </td>
                                </tr>
                            </table>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <table><tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="نام درس :"></asp:Label>
                                </td>
                                <td><asp:TextBox ID="name" runat="server" Text='<%# Eval("coursName") %>'></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="coursecode" runat="server" Text="كد درس :"></asp:Label></td>
                                <td >
                                    <asp:Label ID="ccode" runat="server" Text='<%# Eval("courseCode") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="كد رشته :"></asp:Label></td>
                                    <td >
                                <asp:TextBox ID="rcode" runat="server" Text='<%# Eval("codeReshteh") %>'></asp:TextBox></td>
                                 <td >
                                </td>
                                    <td >
                                    </td>
                                    </tr>
                                <tr>
                                    <td style="height: 40px">
                                <asp:Label ID="Label7" runat="server" Text="نمره قبولي :"></asp:Label></td>
                                    <td >
                                      <asp:TextBox ID="passgread" runat="server" Text='<%# Eval("passGread") %>'></asp:TextBox></td>
                                    <td style=" height: 40px">
                                <asp:Label ID="Label8" runat="server" Text="نوع درس :"></asp:Label></td>
                                    <td style="height: 40px; ">
                                <asp:TextBox ID="type" runat="server" Text='<%# Eval("corseType") %>'></asp:TextBox></td>
                                    
                                </tr>
                                <tr>
                                    <td style="height: 40px">
                                <asp:Label ID="Label9" runat="server" Text="تعداد واحد نظري :"></asp:Label></td>
                                    <td style=" height: 40px">
                                        <asp:TextBox ID="nunit" runat="server" Text='<%# Eval("nUnit") %>'></asp:TextBox></td>
                                    <td style=" height: 40px">
                                <asp:Label ID="Label10" runat="server" Text="تعداد واحد عملي :"></asp:Label></td>
                                    <td style="height: 40px;">
                                <asp:TextBox ID="aunit" runat="server" Text='<%# Eval("aUnit") %>'></asp:TextBox></td>
                                 </tr>
                            </table>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType=Link CancelText="انصراف" EditText="ويرايش" HeaderText="ويرايش"
                            ShowEditButton="True" UpdateText="تاييد" />
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
