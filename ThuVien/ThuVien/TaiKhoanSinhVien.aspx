<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoanSinhVien.aspx.cs" Inherits="QLThuVien.TaiKhoanSinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            height: 26px;
            width: 94px;
        }
        .auto-style4 {
            width: 94px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="ĐĂNG KÝ TÀI KHOẢN"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Mã sinh viên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaSinhVien" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Họ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHo" runat="server" AutoPostBack="True" OnTextChanged="txtHo_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTen" runat="server" AutoPostBack="True" OnTextChanged="txtTen_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Họ tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHoTen" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Ngày sinh"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlNgay" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlThang" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlThang_SelectedIndexChanged">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlNam" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Giới tính"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rbtnGioiTinh" runat="server">
                        <asp:ListItem Value="true">Nam</asp:ListItem>
                        <asp:ListItem Value="false">Nữ</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Nơi sinh"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNoiSinh" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Ngành</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlNganh" runat="server" DataSourceID="SqlDataSource1" DataTextField="TenNganh" DataValueField="MaNganh">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLThuVienConnectionString %>" SelectCommand="SELECT [MaNganh], [TenNganh] FROM [Nganh]"></asp:SqlDataSource>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label10" runat="server" Text="Mật khẩu"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnDangKy" runat="server" OnClick="btnDangKy_Click" Text="Đăng ký" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
