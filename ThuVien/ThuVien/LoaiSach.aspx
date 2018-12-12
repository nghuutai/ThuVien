<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoaiSach.aspx.cs" Inherits="QLThuVien.LoaiSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 105px;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 105px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="font-size: large; margin-left: 40px;" class="auto-style4">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx">Trang chủ</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DonVi.aspx">Đơn vị</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/LoaiSach.aspx">Loại sách</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Nganh.aspx">Ngành</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/NhaXuatBan.aspx">Nhà xuất bản</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Sach.aspx">Sách</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/TacGia.aspx">Tác giả</asp:HyperLink>
                &nbsp;<asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/TraSach.aspx">Trả sách</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="font-size: large" class="auto-style4">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="font-size: large" class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="LOẠI SÁCH"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Mã loại sách"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaLoaiSach" runat="server" Width="154px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMaLoaiSach" runat="server" ControlToValidate="txtMaLoaiSach" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Tên loại sách"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtTenLoaiSach" runat="server" Width="153px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTenLoaiSach" runat="server" ControlToValidate="txtTenLoaiSach" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" style="height: 26px" Text="Thêm" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaLoai" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="MaLoai" HeaderText="MaLoai" ReadOnly="True" SortExpression="MaLoai" />
                            <asp:BoundField DataField="TenLoaiSach" HeaderText="TenLoaiSach" SortExpression="TenLoaiSach" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT * FROM [LoaiSach]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
