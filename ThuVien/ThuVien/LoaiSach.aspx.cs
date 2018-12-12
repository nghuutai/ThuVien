using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class LoaiSach : System.Web.UI.Page
    {
        loaisach ls = new loaisach();
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
            ls = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaLoaiSach(ls.MaLoai);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertLoaiSach(ls);
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
        public loaisach LayDuLieuTuForm()
        {
            loaisach ls = new loaisach()
            {
                MaLoai = txtMaLoaiSach.Text,
                TenLoaiSach = txtTenLoaiSach.Text
            };
            return ls;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllLoaiSach();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoai = GridView1.SelectedRow.Cells[0].Text;
            ls = cn.GetLoaiSachByID(maLoai);
            if (ls != null)
            {
                txtMaLoaiSach.Text = ls.MaLoai;
                txtTenLoaiSach.Text = ls.TenLoaiSach;
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            ls = LayDuLieuTuForm();
            bool result = cn.UpdateLoaiSach(ls);
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
            string maLoai = GridView1.Rows[e.RowIndex].Cells[0].Text;
            bool result = cn.DeleteLoaiSach(maLoai);
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