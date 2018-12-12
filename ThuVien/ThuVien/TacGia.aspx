<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TacGia.aspx.cs" Inherits="QLThuVien.TacGia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style4 {
            width: 155px;
        }
        .auto-style5 {
            width: 209px;
        }
        .auto-style6 {
            text-align: center;
            height: 15px;
        }
        .auto-style7 {
        }
        .auto-style8 {
        }
        .auto-style9 {
            width: 93px;
        }
        .auto-style10 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" colspan="4">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx" style="font-size: large">Trang chủ</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DonVi.aspx" style="font-size: large">Đơn vị</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/LoaiSach.aspx" style="font-size: large">Loại sách</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Nganh.aspx" style="font-size: large">Ngành</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink5" runat="server" CssClass="auto-style10" NavigateUrl="~/NhaXuatBan.aspx">Nhà xuất bản</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink6" runat="server" CssClass="auto-style10" NavigateUrl="~/Sach.aspx">Sách</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink7" runat="server" CssClass="auto-style10" NavigateUrl="~/TacGia.aspx">Tác giả</asp:HyperLink>
                &nbsp;<asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/TraSach.aspx">Trả sách</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="4">
                    <asp:Label ID="Label1" runat="server" style="font-size: large" Text="TÁC GIẢ"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label2" runat="server" Text="Mã tác giả"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtMaTacGia" runat="server" Width="177px" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="rfvMaTacGia" runat="server" ControlToValidate="txtMaTacGia" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label3" runat="server" Text="Tên tác giả"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtTenTacGia" runat="server" Width="175px" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="rfvTenTacGia" runat="server" ControlToValidate="txtTenTacGia" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnThem" runat="server" style="text-align: right" Text="Thêm" OnClick="btnThem_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="4">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaTacGia" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="MaTacGia" HeaderText="MaTacGia" ReadOnly="True" SortExpression="MaTacGia" />
                            <asp:BoundField DataField="TenTacGia" HeaderText="TenTacGia" SortExpression="TenTacGia" />
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT * FROM [TacGia]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
