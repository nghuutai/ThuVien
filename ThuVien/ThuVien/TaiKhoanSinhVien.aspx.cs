using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuVien
{
    public partial class TaiKhoanSinhVien : System.Web.UI.Page
    {
        sinhvien sv = new sinhvien();
        chucnang cn = new chucnang();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i < 12; i++)
                {
                    ddlThang.Items.Add(new ListItem(i.ToString(),i.ToString()));
                }
                for (int i = 1; i < 31; i++)
                {
                    ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                for (int i = 1990; i < 2020; i++)
                {
                    ddlNam.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }

        protected void txtHo_TextChanged(object sender, EventArgs e)
        {
            txtHoTen.Text = txtHoTen.Text + txtHo.Text;
        }

        protected void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        protected void ddlThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int thang = int.Parse(ddlThang.SelectedValue.ToString());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ddlNgay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                    }
                    break;
                case 2:
                    ddlNgay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                    {
                        ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ddlNgay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                    }
                    break;
            }
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            sv = LayDuLieuTuForm();
            cn = new chucnang();
            bool exist = cn.CheckMaSinhVien(sv.MaSinhVien);
            if (exist)
            {
                lblThongBao.Text = "Tác Giả này đã có";
            }
            else
            {
                bool result = cn.InsertSinhVien(sv);
                if (result)
                {
                    lblThongBao.Text = "Thêm thành công";
                    XoaNoiDung(Page);
                }
                else
                {
                    lblThongBao.Text = "Có lỗi";
                }
            }
        }
        public sinhvien LayDuLieuTuForm()
        {
            sinhvien sv = new sinhvien()
            {
                MaSinhVien=txtMaSinhVien.Text,
                Ho=txtHo.Text,
                Ten=txtTen.Text,
                HoTen=txtHoTen.Text,
                NgaySinh= new DateTime(int.Parse(ddlNam.SelectedValue),int.Parse(ddlThang.SelectedValue),int.Parse(ddlNgay.SelectedValue)),
                GioiTinh=Boolean.Parse(rbtnGioiTinh.SelectedValue),
                NoiSinh=txtNoiSinh.Text,
                MaNganh=ddlNganh.SelectedValue,
                MatKhau=txtMatKhau.Text
            };
            return sv;
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
    }
}