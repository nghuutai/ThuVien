using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class NhaXuatBan : System.Web.UI.Page
    {
        nhaxuatban nxb = new nhaxuatban();
        chucnang cn = new chucnang();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            nxb = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaNhaXuatBan(nxb.MaNhaXuatBan);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertNhaXuatBan(nxb);
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
        public nhaxuatban LayDuLieuTuForm()
        {
            nhaxuatban nxb = new nhaxuatban()
            {
                MaNhaXuatBan = txtMaNhaXuatBan.Text,
                TenNhaXuatBan = txtTenNhaXuatBan.Text,
                DiaChi=txtDiaChi.Text,
                SoDienThoai=txtSoDienThoai.Text
            };
            return nxb;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllNhaXuatBan();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNXB = GridView1.SelectedRow.Cells[0].Text;
            nxb = cn.GetNhaXuatBanByID(maNXB);
            if (nxb != null)
            {
                txtMaNhaXuatBan.Text = nxb.MaNhaXuatBan;
                txtTenNhaXuatBan.Text = nxb.TenNhaXuatBan;
                txtDiaChi.Text = nxb.DiaChi;
                txtSoDienThoai.Text = nxb.SoDienThoai;
            };
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            nxb = LayDuLieuTuForm();
            bool result = cn.UpdateNhaXuatBan(nxb);
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
            string maNXB = GridView1.Rows[e.RowIndex].Cells[0].Text;
            bool result = cn.DeleteNhaXuatBan(maNXB);
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