<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MuonSach.aspx.cs" Inherits="ThuVien.MuonSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
            width: 119px;
        }
        .auto-style5 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" Text="MƯỢN SÁCH"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Mã sinh viên"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMaSinhVien" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" Text="Mã cán bộ"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMaCanBo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label4" runat="server" Text="Mã sách"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMaSach" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label5" runat="server" Text="Số lượng"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label6" runat="server" Text="Ngày mượn"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNgayMuon" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server" Text="Ngày trả"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNgayTra" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label8" runat="server" Text="Trạng thái"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="false" Selected="True">Đang mượn</asp:ListItem>
                    <asp:ListItem Value="true">Đã trả</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnMuonSach" runat="server" Text="Mượn sách" OnClick="btnMuonSach_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="lblThongBao" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TrangChu.aspx">Tiếp tục mượn sách</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
