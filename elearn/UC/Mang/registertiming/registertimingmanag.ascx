<%@ Control Language="C#" AutoEventWireup="true" CodeFile="registertimingmanag.ascx.cs" Inherits="UC_Mang_registertiming_registertimingmanag" %>
<%@ Register Assembly="AspNetPersianDatePickup" Namespace="AspNetPersianDatePickup" TagPrefix="pcal" %>
<table dir="rtl" style="border-right: maroon 2px solid; border-top: maroon 2px solid;
    border-left: maroon 2px solid; width: 95%; border-bottom: maroon 2px solid">
    <tr>
        <td colspan="6" style="font-weight: bold; font-size: 16px; color:Blue
            border-bottom: maroon 2px solid; font-family: Arial; text-align: center">
            مدیریت انتخاب واحد</td>
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
                         <asp:Label ID="Label1" runat="server" Text="كد دوره :"></asp:Label></td>
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
                    PageSize="15" RowStyle-Width="100%" Width="100%" OnRowCancelingEdit="gvPageManag_RowCancelingEdit" 
                    OnRowEditing="gvPageManag_RowEditing" OnRowUpdating="gvPageManag_RowUpdating" >
<PagerSettings Mode="NumericFirstLast"></PagerSettings>

<RowStyle Width="100%"></RowStyle>
<Columns>
<asp:TemplateField><EditItemTemplate>
    <table cellSpacing=0 cellPadding=0 width="100%" border=0>
    <tbody>
    <tr>
    <td style=" TEXT-ALIGN: right; height: 24px;">
        &nbsp;<asp:Label ID="lblinput" runat="server" Font-Names="Tahoma" Font-Size="12px"
            Text='<%# Eval("inputDorehCode") %>'></asp:Label>
    </TD>
    <td style=" TEXT-ALIGN: right; height: 24px;">
    <pcal:PersianDatePickup id="pdpr" runat="server" Text='<%# Eval("regBeginDate") %>' Font-Size="12px" Font-Names="Tahoma"></pcal:PersianDatePickup> </TD>
    <td style=" text-align: right; height: 24px;">
    <pcal:PersianDatePickup ID="pdprexp" runat="server" Text='<%# Eval("regExpDate") %>'></pcal:PersianDatePickup></td>
    <td style=" text-align: right; height: 24px;">
        <pcal:PersianDatePickup ID="pdpar" runat="server" Text='<%# Eval("addRemBeginDate") %>'></pcal:PersianDatePickup></td>
    <td style=" text-align: right; height: 24px;">
        <pcal:PersianDatePickup ID="pdparexp" runat="server" Text='<%# Eval("addRemExpDate") %>'></pcal:PersianDatePickup></td>
    <td style=" text-align: right; height: 24px;">
        <pcal:PersianDatePickup ID="pdpe" runat="server" Text='<%# Eval("emgRemBeginDate") %>'></pcal:PersianDatePickup></td>
    <td style=" text-align: right; height: 24px;">
        <pcal:PersianDatePickup ID="pdpeexp" runat="server" Text='<%# Eval("emgRemExpDate") %>'></pcal:PersianDatePickup></td>
        <tr>
            <td style="height: 22px; text-align: right">
            </td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lblr" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("regBeginDate") %>'></asp:Label></td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lblrexp" runat="server" Text='<%# Eval("regExpDate") %>'></asp:Label></td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lblar" runat="server" Text='<%# Eval("addRemBeginDate") %>'></asp:Label></td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lblarexp" runat="server" Text='<%# Eval("addRemExpDate") %>'></asp:Label></td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lble" runat="server" Text='<%# Eval("emgRemBeginDate") %>'></asp:Label>
            </td>
            <td style="height: 22px; text-align: right">
                <asp:Label ID="lbleexp" runat="server" Text='<%# Eval("emgRemExpDate") %>'></asp:Label></td>
        </tr>
    
</EditItemTemplate>
<HeaderTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    ورودي</TH><th style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: right; height: 19px;">
    انتخاب واحد</TH>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        پايان انتخاب واحد</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        حذف و اضافه</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        پايان حذف و اضافه</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        حذف اضطراري</th>
    <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
        پايان حذف اضطراري</th>
    <TH style="FONT-SIZE: 16px; WIDTH: 199px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center" valign="middle">
    &nbsp;حذف</TH><TH style="FONT-SIZE: 16px; WIDTH: 150px; FONT-FAMILY: Arial; TEXT-ALIGN: center; height: 19px;" align="center">
    &nbsp;ويرايش</TH></TR></TBODY></TABLE>
</HeaderTemplate>
<ItemTemplate>
<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblinput" runat="server"
 Text='<%# Eval("inputDorehCode") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD><TD style="WIDTH: 150px; TEXT-ALIGN: right"><asp:Label id="lblr" runat="server" Text='<%# Eval("regBeginDate") %>' Font-Size="12px" Font-Names="Tahoma"></asp:Label> </TD>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblrexp" runat="server" Text='<%# Eval("regExpDate") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblar" runat="server" Text='<%# Eval("addRemBeginDate") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lblarexp" runat="server" Text='<%# Eval("addRemExpDate") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lble" runat="server" Text='<%# Eval("emgRemBeginDate") %>'></asp:Label></td>
    <td style="width: 150px; text-align: right">
        <asp:Label ID="lbleexp" runat="server" Text='<%# Eval("emgRemExpDate") %>'></asp:Label></td>
    <td style=" text-align: right">
    <a href="../ControlPanel/manag.aspx?page=delregt&id=<%# Eval("dorehCode")%>&id1=<%# Eval("inputDorehCode")%>">حذف  </a></td>
   </TR>
   </TBODY>
   </TABLE>
</ItemTemplate>
</asp:TemplateField>
    <asp:CommandField ShowEditButton="True" UpdateText="تاييد" CancelText="انصراف" EditText="ويرايش" HeaderText="ويرايش" />
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
        &nbsp;</center></td></tr>
</table>
