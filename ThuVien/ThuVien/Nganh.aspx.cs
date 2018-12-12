using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class Nganh : System.Web.UI.Page
    {
        nganh ng = new nganh();
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
            ng = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaNganh(ng.MaNganh);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertNganh(ng);
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
        public nganh LayDuLieuTuForm()
        {
            nganh ng = new nganh()
            {
                MaNganh=txtMaNganh.Text,
                TenNganh=txtTenNganh.Text,
                SoTinChi=int.Parse(txtSoTinChi.Text),
                SoHK=int.Parse(txtSoHocKi.Text),
                MaKhoa=ddlKhoa.SelectedValue.ToString()
            };
            return ng;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllNganh();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = GridView1.SelectedRow.Cells[0].Text;
            ng = cn.GetNganhByID(ma);
            if (ng != null)
            {
                txtMaNganh.Text = ng.MaNganh;
                txtTenNganh.Text = ng.TenNganh;
                txtSoTinChi.Text = ng.SoTinChi.ToString();
                txtSoHocKi.Text = ng.SoHK.ToString();
                ddlKhoa.SelectedValue = ng.MaKhoa;
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            ng = LayDuLieuTuForm();
            bool result = cn.UpdateNganh(ng);
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
            bool result = cn.DeleteNganh(ma);
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