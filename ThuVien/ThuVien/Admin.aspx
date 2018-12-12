<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ThuVien.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ HỆ THỐNG THƯ VIỆN"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DonVi.aspx">Đơn vị</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/LoaiSach.aspx">Loại sách</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Nganh.aspx">Ngành</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/NhaXuatBan.aspx">Nhà xuất bản</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Sach.aspx">Sách</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/TacGia.aspx">Tác giả</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/TraSach.aspx">Trả Sách</asp:HyperLink>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
