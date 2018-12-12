using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class DangNhapAdmin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            chucnag cn = new chucnag();
            bool kq = cn.DangNhapAdmin(txtTenDangNhap.Text, txtMatKhau.Text);
            if (kq)
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                lblThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }
    }
}