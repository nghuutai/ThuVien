using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            if (!IsPostBack)
            {
                lblNhan.Text = "Xin chào: " + Session["masv"].ToString();
                DoDuLieuVaoGridView();
                ddlChiTiet.DataSource = cn.GetTacGia();
                ddlChiTiet.DataTextField = "TenTacGia";
                ddlChiTiet.DataValueField = "MaTacGia";
                ddlChiTiet.DataSourceID = null;
                ddlChiTiet.DataBind();

            }
        }
        public void DoDuLieuVaoGridView()
        {
            chucnag cn = new chucnag();
            GridView1.DataSource = cn.GetAllSach();
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            GridView1.DataSource = cn.GetAllSachByTen(txtTimKiem.Text);
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnMuon_Click(object sender, EventArgs e)
        {
            Session["masach"] = (sender as Button).CommandArgument;
            Response.Redirect("MuonSach.aspx");
        }

        protected void ddlLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            if (ddlLoai.SelectedValue.ToString() == "TG")
            {
                ddlChiTiet.DataSource = cn.GetTacGia();
                ddlChiTiet.DataTextField = "TenTacGia";
                ddlChiTiet.DataValueField = "MaTacGia";
                ddlChiTiet.DataSourceID = null;
                ddlChiTiet.DataBind();
            }
            else if (ddlLoai.SelectedValue.ToString() == "NXB")
            {
                ddlChiTiet.DataSource = cn.GetNhaXuatBan();
                ddlChiTiet.DataTextField = "TenNhaXB";
                ddlChiTiet.DataValueField = "MaNhaXB";
                ddlChiTiet.DataSourceID = null;
                ddlChiTiet.DataBind();
            }
            else
            {
                ddlChiTiet.DataSource = cn.GetLoaiSach();
                ddlChiTiet.DataTextField = "TenLoaiSach";
                ddlChiTiet.DataValueField = "MaLoai";
                ddlChiTiet.DataSourceID = null;
                ddlChiTiet.DataBind();
            }
        }

        protected void ddlChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            if (ddlLoai.SelectedValue.ToString() == "TG")
            {
                GridView1.DataSource = cn.GetAllSachByTacGia(ddlChiTiet.SelectedValue.ToString());
                GridView1.DataSourceID = null;
                GridView1.DataBind();
            }
            else if (ddlLoai.SelectedValue.ToString() == "NXB")
            {
                GridView1.DataSource = cn.GetAllSachByNhaXuatBan(ddlChiTiet.SelectedValue.ToString());
                GridView1.DataSourceID = null;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = cn.GetAllSachByLoaiSach(ddlChiTiet.SelectedValue.ToString());
                GridView1.DataSourceID = null;
                GridView1.DataBind();
            }
        }
    }
}