<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhapAdmin.aspx.cs" Inherits="ThuVien.DangNhapAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 106px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="ĐĂNG NHẬP"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Tên đăng nhập"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Mật khẩu"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
