<%@ Control Language="C#" AutoEventWireup="true" CodeFile="newReg.ascx.cs" Inherits="UC_Mang_Register_newReg" %>
<table dir ="rtl"  style="width:100%;border-right: maroon 2px solid; border-top: maroon 2px solid; border-left:
   maroon 2px solid; border-bottom: maroon 2px solid">
   <tr>
   <td colspan="6"  
   style="text-align:center ;font-family:Arial;font-size:16px; font-weight:bold ;
   border-bottom: maroon 2px solid; color:Blue;">
       انتخاب واحد</td>
   </tr>
<tr style="height:40px"><td colspan="6" style ="font-family:Arial ;font-size:16px; font-weight:bold ;
vertical-align:middle;border-bottom: maroon 2px solid;"><center>
<table cellpadding="5" border="0"  width ="100%" >
<tr>
<td style="text-align:center ;width:40px; height: 35px;">
<asp:Image ID="imSuccess" runat="server" Height="25px" ImageUrl="../../../images/succes.GIF"
        Visible="false" Width="25px" /></td>
<td   style="vertical-align:middle; height: 35px;" colspan="5" >
    <asp:Label ID="lblMessage" runat="server" 
    style ="font-family:Arial ;font-size:16px; font-weight:bold ;"></asp:Label>&nbsp;&nbsp;&nbsp;
</td>
</tr>
</table>
       &nbsp;&nbsp;
   </center>

</td>
</tr>
<tr>
<td align ="center" style="border-bottom: #333366 thin solid" >
<table style ="width:100%">
<tr>
<td style="height: 22px">
شماره دانشجویی/ دانش آموزی
</td>
<td style="height: 22px">
<asp:Label  ID ="lblStdNo" runat ="server" ></asp:Label>
</td>
<td style="height: 22px">
نام خانوادگی :
</td>
<td style="height: 22px">
<asp:Label runat="server"  ID ="lblfamily" ></asp:Label>
</td>
</tr>
<tr>
<td>
    نام</td>
<td>
<asp:Label  ID ="lblName" runat ="server" ></asp:Label>
</td>
<td>
نام پدر :</td>
<td>
<asp:Label runat="server"  ID ="lblfather" ></asp:Label>
</td>
</tr>
<tr>
<td>
    کد ملی :</td>
<td>
<asp:Label  ID ="lblCodeMeli" runat ="server" ></asp:Label>
</td>
<td>
    شماره شناسنامه:</td>
<td>
<asp:Label runat="server"  ID ="lblShSh" ></asp:Label>
</td>
</tr>
<tr>
<td>
    ترم تحصیلی</td>
<td>
<asp:Label  ID ="lblTerm" runat ="server" ></asp:Label>
</td>
<td>
    سال تحصیلی</td>
<td>
<asp:Label runat="server"  ID ="lblYear" ></asp:Label>
</td>
</tr>
</table>
   </td>
</tr>
    <tr>
        <td align="center" >
        <table style ="width:100%">
<tr>
<td style="height: 22px; text-align: center;" colspan="4">
    دروس احذ شده</td>
</tr>
<tr>
<td colspan="4" rowspan="3" style="text-align: center">
    <asp:GridView ID="gvPageManag" runat="server" AllowPaging="True" AutoGenerateColumns="False"
         PageSize="5" RowStyle-Width="100%" Width="100%">
        <PagerSettings Mode="NumericFirstLast" /><Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                </EditItemTemplate>
                <HeaderTemplate>
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <th style="font-size: 16px; width: 150px; font-family: Arial; text-align: right;
                                height: 19px;">
                                کد درس</th>
                            <th style="font-size: 16px; width: 150px; font-family: Arial; text-align: right;
                                height: 19px;">
                                نام درس</th>
                            <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                تعداد واحد</th>
                            <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                نوع درس</th>
                            <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                وضعیت</th>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField CancelText="انصراف" EditText="ويرايش" HeaderText="ويرايش"
                UpdateText="تاييد" ShowDeleteButton="True" />
        </Columns>
        <RowStyle Width="100%" />
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
    <asp:Button ID="Button1" runat="server" Text="ثبت نهایی" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   /></td>
</tr>
<tr>
</tr>
<tr>
</tr>
            <tr>
                <td colspan="4" rowspan="1">
                    <asp:GridView ID="gvAllCourse" runat="server" AllowPaging="True" AutoGenerateColumns="False" RowStyle-Width="100%" Width="100%" OnSelectedIndexChanging="gvAllCourse_SelectedIndexChanging">
                        <PagerSettings Mode="NumericFirstLast" />
                        <Columns>
                            <asp:TemplateField>
                                <EditItemTemplate>
                                </EditItemTemplate>
                                <HeaderTemplate>
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <th style="font-size: 16px; width: 100px; font-family: Arial; text-align: right;height: 19px;">
                                                کد درس</th>
                                            <th style="font-size: 16px; width: 150px; font-family: Arial; text-align: right;  height: 19px;">
                                                نام درس</th>
                                            <th style="font-size: 16px; width: 50px; font-family: Arial; height: 19px; text-align: right">
                                                تعداد واحد عملی</th>
                                                <th style="font-size: 16px; width: 50px; font-family: Arial; height: 19px; text-align: right">
                                                تعداد واحد نظری</th>
                                            <th style="font-size: 16px; width: 70px; font-family: Arial; height: 19px; text-align: right">
                                               ظرفیت کلاس</th>
                                                  <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                                مدرس</th>
                                                  <th style="font-size: 16px; width: 150px; font-family: Arial; height: 19px; text-align: right">
                                                تاریخ و ساعت امتحان</th>
                                                  <th style="font-size: 16px; width: 50px; font-family: Arial; height: 19px; text-align: right">
                                                شعبه</th>
                                        </tr>
                                    </table>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <table>
                                <tr>
                                <td style="width:100px;">
                                <asp:Label ID="Label1" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("courseCode") %>'  ></asp:Label>
                                </td>
                                <td  style="width:150px">
                                <asp:Label ID="Label3" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("coursName") %>'  ></asp:Label>
                                </td>
                                <td  style="width:50px">
                                <asp:Label ID="Label2" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("aUnit") %>'  ></asp:Label>
                                </td>
                                <td style="width:50px">
                                <asp:Label ID="Label4" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("nUnit") %>'  ></asp:Label>
                                </td>
                                <td style="width:70px">
                                <asp:Label ID="Label5" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("capacity") %>'  ></asp:Label>
                                </td>
                                <td style="width:150px">
                                <asp:Label ID="Label6" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("Name") %>'  ></asp:Label>
                                </td>
                                <td style="width:150px">
                                <asp:Label ID="Label7" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("date") %>'  ></asp:Label>
                                </td>
                                 <td style="width:50px">
                                <asp:Label ID="Label8" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("branche") %>'  ></asp:Label>
                                <asp:Label ID="lblID" runat="server" Font-Names="Tahoma" Font-Size="12px" Text='<%# Eval("id") %>' ></asp:Label>
                                </td>
                                </tr>
                                </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ButtonType="Button" SelectText="اضافه" ShowSelectButton="True" />
                        </Columns>
                        <RowStyle Width="100%" />
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
                </td>
            </tr>
</table>
            </td>
    </tr>
    <tr>
        <td align="center" colspan="6">
            <asp:Button ID="btnCancel" runat="server" Text="انصراف" 
    Font-Names="Courier New" Font-Size="12pt" OnClick="btnCancel_Click"   /></td>
    </tr>
</table>