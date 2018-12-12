using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangnhap_Click(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            bool kq = cn.DangNhap(txtDangNhap.Text, txtMatKhau.Text);
            if (kq)
            {
                Session["masv"] = txtDangNhap.Text;
                Response.Redirect("TrangChu.aspx");
            }
            else
            {
                lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }
    }
}