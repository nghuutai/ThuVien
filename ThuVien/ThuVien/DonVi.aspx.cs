using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class DonVi : System.Web.UI.Page
    {
        donvi dv = new donvi();
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
            dv = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaDonVi(dv.MaDonVi);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertDonVi(dv);
                if (result)
                {
                    lblThongBao.Text = "Thêm thành công";
                    DoDuLieuVaoGridView();
                    XoaNoiDung(Page);
                }
                else
                {
                    lblThongBao.Text = "Có lỗi";
                }
            }
        }
        private void XoaNoiDung(Control ctrl)
        {
            if (ctrl is TextBox)
            {
                (ctrl as TextBox).Text = string.Empty;
            }
            foreach (Control i in ctrl.Controls)
            {
                XoaNoiDung(i);
            }
        }
        public donvi LayDuLieuTuForm()
        {
            donvi dv = new donvi()
            {
                MaDonVi=txtMaDonVi.Text,
                TenDonVi=txtTenDonVi.Text,
                DiaChi=txtDiaChi.Text,
                SoDienThoai=txtSoDienThoai.Text,
                Website=txtWebsite.Text
            };
            return dv;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllDonVi();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = GridView1.SelectedRow.Cells[0].Text;
            dv = cn.GetDonViByID(ma);
            if (dv != null)
            {
                txtMaDonVi.Text = dv.MaDonVi;
                txtTenDonVi.Text = dv.TenDonVi;
                txtDiaChi.Text = dv.DiaChi;
                txtSoDienThoai.Text = dv.SoDienThoai;
                txtWebsite.Text = dv.Website;
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            dv = LayDuLieuTuForm();
            bool result = cn.UpdateDonVi(dv);
            if (result)
            {
                lblThongBao.Text = "Cập nhập thành công";
                DoDuLieuVaoGridView();
                XoaNoiDung(Page);
            }
            else
            {
                lblThongBao.Text = "Có lỗi";
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ma = GridView1.Rows[e.RowIndex].Cells[0].Text;
            bool result = cn.DeleteDonVi(ma);
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