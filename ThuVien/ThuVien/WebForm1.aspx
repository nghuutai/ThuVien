<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ThuVien.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 126px;
    }
    .auto-style4 {
        width: 117px;
    }
    .auto-style5 {
        text-align: left;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align: center">
    ĐĂNG NHẬP</p>
<p style="text-align: center">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDangNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="Mật khẩu"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td style="text-align: left">
                <asp:Button ID="btnDangnhap" runat="server" style="text-align: left; height: 26px;" Text="Đăng nhập" OnClick="btnDangnhap_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td style="text-align: left">
                <asp:Label ID="lblThongBao" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</p>
</asp:Content>
