using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace ThuVien
{
    public partial class TraSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DoDuLieuVaoGridView();
                
            }
        }
        private void DoDuLieuVaoGridView()
        {
            chucnag cn = new chucnag();
            GridView1.DataSource = cn.GetAllMuonSach();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            GridView1.DataSource = cn.GetMuonSachBySV(txtMaSV.Text);
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void btnTraSach_Click(object sender, EventArgs e)
        {
            string ma = (sender as Button).CommandArgument;
            int sl=int.Parse(GridView1.SelectedRow.Cells[4].Text);
            DateTime ngayMuon, ngayTra;

            ngayMuon = DateTime.Parse(GridView1.SelectedRow.Cells[5].Text);
            ngayTra = DateTime.Parse(GridView1.SelectedRow.Cells[6].Text);

            //lblThongBao.Text = ngayMuon.ToString(); 
            
            chucnag cn = new chucnag();
            bool kq = cn.UpdateTinhTrangMuonSach(txtMaSV.Text, ma, ngayMuon.ToString("yyyy-MM-dd"), ngayTra.ToString("yyyy-MM-dd"));
            if (kq)
            {
                lblThongBao.Text = "Trả sách thành công";
                cn.UpdateSoLuongSachTra(ma, sl);
                DoDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Có lỗi";
            }
        }
    }
}