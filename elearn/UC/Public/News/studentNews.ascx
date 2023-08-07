<%@ Control Language="C#" AutoEventWireup="true" CodeFile="studentNews.ascx.cs" Inherits="UC_Public_News_studentNews" %>
<table  width ="190px" cellpadding = "0" cellspacing ="0" border ="0" >
<tr>
<td align ="center" >
<asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="5" RowStyle-Width="100%" Width="100%" BorderWidth ="0px" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%" >
                                    <tr>
                                        <td  style ="padding:0px 5px 0px 5px">
                                         <asp:Label ID="Label1" runat="server" Font-Names="Tahoma" Font-Size="12px" 
                                                Text='<%# Eval("Title") %>'></asp:Label>
                                        </td>
                                        </tr>
                                        </table>
                                <hr />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle Width="100%" />
                </asp:GridView>
</td>
</tr>
</table>