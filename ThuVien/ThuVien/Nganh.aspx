<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nganh.aspx.cs" Inherits="QLThuVien.Nganh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 102px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="font-size: large">
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
                    <asp:Label ID="Label1" runat="server" Text="NGÀNH"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Mã ngành"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaNganh" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMaNganh" runat="server" ControlToValidate="txtMaNganh" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Tên ngành"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTenNganh" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTenNganh" runat="server" ControlToValidate="txtTenNganh" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Số tín chỉ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSoTinChi" runat="server" Height="22px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSoTinChi" runat="server" ControlToValidate="txtSoTinChi" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Số học kì"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSoHocKi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSoHocKi" runat="server" ControlToValidate="txtSoHocKi" ErrorMessage="Không được để trống ô này"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Khoa"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlKhoa" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenDV" DataValueField="MaDV">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT [MaDV], [TenDV] FROM [DonVi]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3">
                    <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" />
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
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaNganh" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="MaNganh" HeaderText="MaNganh" ReadOnly="True" SortExpression="MaNganh" />
                            <asp:BoundField DataField="TenNganh" HeaderText="TenNganh" SortExpression="TenNganh" />
                            <asp:BoundField DataField="SoTinChi" HeaderText="SoTinChi" SortExpression="SoTinChi" />
                            <asp:BoundField DataField="SoHK" HeaderText="SoHK" SortExpression="SoHK" />
                            <asp:BoundField DataField="MaKhoa" HeaderText="MaKhoa" SortExpression="MaKhoa" />
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT * FROM [Nganh]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
