using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class Sach : System.Web.UI.Page
    {
        sach s = new sach();
        chucnang cn = new chucnang();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DoDuLieuVaoGridView();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            s = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaSach(s.MaSach);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertSach(s);
                if (result)
                {
                    lblThongBao.Text = "Thêm thành công";
                    DoDuLieuVaoGridView();
                }
                else
                {
                    lblThongBao.Text = "Có lỗi";
                }
            }
        }
        public sach LayDuLieuTuForm()
        {
            sach s = new sach()
            {
                MaSach=txtMaSach.Text,
                TenSach=txtTenSach.Text,
                MaNhaXuatBan=ddlNhaXuatBan.SelectedValue.ToString(),
                MoTa=txtMoTa.Text,
                MaLoai=ddlLoaiSach.SelectedValue.ToString(),
                MaTacGia = ddlTacGia.SelectedValue.ToString(),
                SoLuong = int.Parse(txtSoLuong.Text)
            };
            return s;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllSach();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSach = GridView1.SelectedRow.Cells[0].Text;
            s = cn.GetSachByID(maSach);
            if (s != null)
            {
                txtMaSach.Text = s.MaSach;
                txtTenSach.Text = s.TenSach;
                ddlNhaXuatBan.SelectedValue = s.MaNhaXuatBan;
                txtMoTa.Text = s.MoTa;
                ddlLoaiSach.SelectedValue = s.MaLoai;
                ddlTacGia.SelectedValue = s.MaTacGia;
                txtSoLuong.Text = s.SoLuong.ToString();
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            s = LayDuLieuTuForm();
            bool result = cn.UpdateSach(s);
            if (result)
            {
                lblThongBao.Text = "Cập nhập thành công";
                DoDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Có lỗi";
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string maSach = GridView1.Rows[e.RowIndex].Cells[0].Text;
            bool result = cn.DeleteSach(maSach);
            if (result)
            {
                lblThongBao.Text = "Xóa thành công";
                DoDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Có lỗi";
            }
        }
    }
}