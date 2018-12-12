<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="ThuVien.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LichSuMuonSach.aspx">Lịch sử mượn sách</asp:HyperLink>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblNhan" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: right" class="auto-style3">
            <asp:TextBox ID="txtTimKiem" runat="server"></asp:TextBox>
            <asp:Button ID="btnTimKiem" runat="server" OnClick="btnTimKiem_Click" style="text-align: right" Text="Tìm kiếm" />
        </td>
        <td class="auto-style3"></td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="ddlLoai" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLoai_SelectedIndexChanged">
                <asp:ListItem Value="TG">Tác giả</asp:ListItem>
                <asp:ListItem Value="NXB">Nhà xuất bản</asp:ListItem>
                <asp:ListItem Value="LS">Loại sách</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlChiTiet" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlChiTiet_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnMuon" runat="server" OnClick="btnMuon_Click" Text="Mượn sách" CommandArgument='<%# Eval("MaSach")%>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ImageField>
                    </asp:ImageField>
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
        </td>
    </tr>
</table>
</asp:Content>
