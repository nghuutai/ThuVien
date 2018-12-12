using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class TacGia : System.Web.UI.Page
    {
        tacgia tg = new tacgia();
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
            tg = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaTacGia(tg.MaTacGia);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertTacGia(tg);
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
        public tacgia LayDuLieuTuForm()
        {
            tacgia tg = new tacgia()
            {
                MaTacGia = txtMaTacGia.Text,
                TenTacGia = txtTenTacGia.Text
            };
            return tg;
        }
        public void DoDuLieuVaoGridView()
        {
            GridView1.DataSource = cn.GetAllTacGia();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTacGia = GridView1.SelectedRow.Cells[0].Text;
            tg = cn.GetTacGiaByID(maTacGia);
            if (tg != null)
            {
                txtMaTacGia.Text = tg.MaTacGia;
                txtTenTacGia.Text = tg.TenTacGia;
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            tg = LayDuLieuTuForm();
            bool result = cn.UpdateTacGia(tg);
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
            string maTacGia = GridView1.Rows[e.RowIndex].Cells[0].Text;
            bool result = cn.DeleteTacGia(maTacGia);
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