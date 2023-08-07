<%@ Control Language="C#" AutoEventWireup="true" CodeFile="coursetimingmanage.ascx.cs" Inherits="UC_Mang_coursetiming_coursetimingmanage" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت زمانبندي دروس</td>
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
                    <td style="height: 34px; width: 93px;">
                        دوره :</td>
                    <td style="height: 34px">
                        <asp:dropdownlist id="doreddl" runat="server" width="138px" DataTextField="Name" DataValueField="CodeDoreh">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
    <td>
         <table border="0" cellpadding="5" width="100%">
                <tr>
                     <td colspan="5" style=" height: 34px; width: 26px;">
                         <asp:Label ID="Label1" runat="server" Text="نام / كد درس :" ></asp:Label></td>
                    <td style="height: 34px">
                        <asp:dropdownlist id="coursecodeddl" runat="server" width="138px" DataTextField="Name" DataValueField="courseCode"></asp:dropdownlist>
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
            زمانبندي تشكيل كلاس هاي درس &nbsp; &nbsp;
            <asp:label id="courselbl" runat="server" text="Label"></asp:label>&nbsp; دوره &nbsp;<asp:Label
                ID="dorelbl" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
        <td>
            <table border="0" cellpadding="5" width="100%">
                <tr>
                    <td colspan="5" style="width: 103px;" align="right">
                        <asp:label id="Label3" runat="server" text="روز :"></asp:label>
                        &nbsp;</td>
                    <td>
                        <asp:dropdownlist id="dayddl" runat="server" width="138px"></asp:dropdownlist></td>
                    <td style="height: 34px">
                        ساعت :</td>
                    <td style="height: 34px">
                        &nbsp;<asp:dropdownlist id="timddl" runat="server" width="138px">
                        </asp:DropDownList></td>
                    <td style="width: 206px; height: 34px">
                        &nbsp;<asp:button id="Button1" runat="server" text="اضافه" width="120px" />&nbsp;
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
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD>عنوان </TD><TD align=center><asp:TextBox id="tbxPageName" Width="325px" runat="server" Text='<%# Eval("newsName") %>'></asp:TextBox> </TD><TD>تاریخ نمایش</TD><TD></TD><TD>تاریخ انقضا</TD></TR><TR><TD>محتوای </TD></TR></TBODY></TABLE>
</EditItemTemplate>
<HeaderTemplate>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;" align="center">نام درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;" align="center">كد درس</TH><TH style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;" align="center">
    ساعت تشكيل&nbsp;</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;" align="center">حذف </TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursename" runat="server" Text='<%# Eval("courseName") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblcoursecode" runat="server" Text='<%# Eval("courseCode") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lbltype" runat="server" Text='<%# Eval("type") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Button id="deletebtn" Width="66px" runat="server" Text="حذف"></asp:Button><A href='../ControlPanel/manag.aspx?page=delnews&id=<%# Eval("id") %>'></A></TD></TR></TBODY></TABLE>
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

