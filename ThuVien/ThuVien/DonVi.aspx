<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonVi.aspx.cs" Inherits="QLThuVien.DonVi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 82px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="font-size: large" class="auto-style4">
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
                <td colspan="3" style="font-size: large">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="font-size: large">
                    <asp:Label ID="Label1" runat="server" Text="ĐƠN VỊ"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Mã đơn vị"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaDonVi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMaDonVi" runat="server" ControlToValidate="txtMaDonVi" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Tên đơn vị"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTenDonVi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTenDonVi" runat="server" ControlToValidate="txtTenDonVi" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Địa chỉ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDiaChi" runat="server" ControlToValidate="txtDiaChi" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Số điện thoại"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSoDienThoai" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSoDienThoai" runat="server" ControlToValidate="txtSoDienThoai" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Website"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtWebsite" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvWebsite" runat="server" ControlToValidate="txtWebsite" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3">
                    <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" style="height: 26px" Text="Thêm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MaDV" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="MaDV" HeaderText="MaDV" ReadOnly="True" SortExpression="MaDV" />
                            <asp:BoundField DataField="TenDV" HeaderText="TenDV" SortExpression="TenDV" />
                            <asp:BoundField DataField="DiaChi" HeaderText="DiaChi" SortExpression="DiaChi" />
                            <asp:BoundField DataField="SDT" HeaderText="SDT" SortExpression="SDT" />
                            <asp:BoundField DataField="Website" HeaderText="Website" SortExpression="Website" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT * FROM [DonVi]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
