using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class LichSuMuonSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNhan.Text = "Xin chào: " + Session["masv"].ToString();
                DoDuLieuVaoForm();
            }
        }
        public void DoDuLieuVaoForm()
        {
            chucnag cn = new chucnag();
            GridView1.DataSource = cn.GetMuonSachBySV(Session["masv"].ToString());
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            bool trangThai = Boolean.Parse(ddlTrangThai.SelectedValue.ToString());
            GridView1.DataSource = cn.LayLichSuMuonSachByTrangThai(Session["masv"].ToString(), trangThai);
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }
    }
}