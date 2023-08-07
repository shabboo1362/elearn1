<%@ Control Language="C#" AutoEventWireup="true" CodeFile="topNewsHome.ascx.cs" Inherits="UC_Public_News_topNewsHome" %>
<table  width ="762px" cellpadding = "0" cellspacing ="0" border ="0" >
<tr>
<td background ="./images/pageContext.jpg" style="width: 762px">
    &nbsp;
</td>
</tr>
<tr>
<td align ="center" style="width:762px; 
vertical-align :middle ;border-left:#FF1493 1px solid;border-right :#FF1493 1px solid;padding:10px 20px 10px 10px;
font-family:Arial;font-size:12pt;font-weight:bold;text-align:right;padding-right:10px;color: deeppink" >
اخبار و اطلاعیه ها  مرکز آموزشی
</td>
</tr>
<tr>
<td align ="center" style="width:762px; 
vertical-align :middle ;border-left:#FF1493 1px solid;border-right :#FF1493 1px solid;padding:10px 20px 10px 10px" >
<asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="5" RowStyle-Width="100%" Width="100%" BorderWidth ="0px" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" width="100%" >
                                    <tr>
                                        <td style="text-align: right;width:100px;height:100px;">
                                            <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl='<%# Eval("ImageName") %>' Width="70px" />
                                        </td>
                                        <td style="text-align: right;">
                                        <table  border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                        <td style ="text-align:right;padding:5px 10px 5px 10px;">
                                         <asp:Label ID="Label1" runat="server" Font-Names="Tahoma" Font-Size="12px" 
                                                Text='<%# Eval("Title") %>'></asp:Label>
                                        </td>
                                        </tr>
                                        <tr>
                                        <td style ="text-align:left;padding:5px 10px 5px 10px;">
                                         <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Tahoma" 
                                            Font-Size="10px" ForeColor="#000099" 
                                            NavigateUrl='<%# Eval("Id","~/index.aspx?id={0}") %>'>جزئیات بیشتر خبر</asp:HyperLink>
                                        </td>
                                        </tr>
                                        </table>
                                               
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
<tr>
<td background ="./images/pageContextb.jpg" style="height:20px; width: 762px;">
    &nbsp;
</td>
</tr>
</table>