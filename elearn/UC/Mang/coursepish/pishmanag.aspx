<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pishmanag.aspx.cs" Inherits="UC_Mang_coursepish_pishmanag" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
    <td>
         <table border="0" cellpadding="5" width="100%">
                <tr>
                     <td colspan="5" style="vertical-align: middle; width: 8px; height: 34px;">
                         <asp:Label ID="Label1" runat="server" Text="نام / كد درس :"></asp:Label>
                     </td>
                    <td style="height: 34px">
                        &nbsp;
                        <asp:dropdownlist id="coursecodeddl" runat="server" width="138px"></asp:dropdownlist>
                    </td>
                    <td style="width: 206px; height: 34px">
                        &nbsp;<asp:button id="searchbtn" runat="server" text="جستجو" width="120px" />&nbsp;
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
                    <td colspan="5" style="vertical-align: middle; width: 84px; height: 34px;" align="right">
                        <asp:label id="Label3" runat="server" text="نام / كد درس :"></asp:label>
                        &nbsp;</td>
                    <td style="width: 137px; height: 34px">
                        &nbsp;
                        <asp:dropdownlist id="DropDownList1" runat="server" width="138px"></asp:dropdownlist>
                    </td>
                    <td style="height: 34px">
                        نوع:</td>
                    <td style="height: 34px">
                        <asp:dropdownlist id="DropDownList2" runat="server" width="138px"></asp:dropdownlist>
                    </td>
                    <td style="width: 206px; height: 34px">
                        &nbsp;<asp:button id="Button1" runat="server" text="جستجو" width="120px" />&nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr><td colspan="6"><center>
                <asp:GridView ID="gvPageManag" runat="server" 
                AllowPaging="True" AutoGenerateColumns="False"
                    PageSize="15" RowStyle-Width="100%" Width="100%">
<PagerSettings Mode="NumericFirstLast"></PagerSettings>

<RowStyle Width="100%"></RowStyle>
<Columns>
<asp:TemplateField><EditItemTemplate>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD>عنوان </TD><TD align=center><asp:TextBox id="tbxPageName" Width="325px" runat="server" Text='<%# Eval("newsName") %>' __designer:wfdid="w11"></asp:TextBox> </TD><TD>تاریخ نمایش</TD><TD></TD><TD>تاریخ انقضا</TD></TR><TR><TD>محتوای </TD></TR></TBODY></TABLE>
</EditItemTemplate>
<HeaderTemplate>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">نام درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">كد درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: right">نوع(پيش نياز / هم نياز)&nbsp;</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right">حذف </TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursename" runat="server" Text='<%# Eval("courseName") %>' Font-Size="12px" Font-Names="Tahoma" __designer:wfdid="w8"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursecode" runat="server" Text='<%# Eval("courseCode") %>' Font-Size="12px" Font-Names="Tahoma" __designer:wfdid="w9"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lbltype" runat="server" Text='<%# Eval("expDate") %>' Font-Size="12px" Font-Names="Tahoma" __designer:wfdid="w10"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Button id="deletebtn" Width="66px" runat="server" Text="حذف" __designer:wfdid="w12"></asp:Button><A href='../ControlPanel/manag.aspx?page=delnews&id=<%# Eval("id") %>'></A></TD></TR></TBODY></TABLE>
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
