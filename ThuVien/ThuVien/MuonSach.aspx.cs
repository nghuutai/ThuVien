using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace ThuVien
{
    public partial class MuonSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = Session["masv"].ToString();
            txtMaSach.Text = Session["masach"].ToString();
        }

        protected void btnMuonSach_Click(object sender, EventArgs e)
        {
            muonsach ms = LayDuLieuTuForm();
            chucnag cn = new chucnag();
            bool kt = cn.CheckSoLuongSach(ms.MaSach, ms.SoLuong);
            if (kt)
            {
                bool exist = cn.CheckMuonSach(ms);
                if (exist)
                {
                        cn.UpdateMuonSach(ms);
                        lblThongBao.Text = "Mượn thành công";
                        cn.UpdateSoLuongSach(ms.MaSach, ms.SoLuong);
                }
                else
                {
                    bool result = cn.InsertMuonSach(ms);
                    if (result)
                    {
                        lblThongBao.Text = "Mượn thành công";
                        cn.UpdateSoLuongSach(ms.MaSach, ms.SoLuong);
                    }
                    else
                    {
                        lblThongBao.Text = "Có lỗi";
                    }
                }
            }
            else
            {
                lblThongBao.Text = "Số lượng sách thư viện không đủ";
            }
        }
        public muonsach LayDuLieuTuForm()
        {
            muonsach ms = new muonsach()
            {
                MaSV=txtMaSinhVien.Text,
                MaCB=txtMaCanBo.Text,
                MaSach=txtMaSach.Text,
                SoLuong=int.Parse(txtSoLuong.Text),
                NgayMuon=DateTime.ParseExact(txtNgayMuon.Text,"dd/MM/yyyy",CultureInfo.InstalledUICulture),
                NgayTra=DateTime.ParseExact(txtNgayTra.Text,"dd/MM/yyyy",CultureInfo.InstalledUICulture),
                TrangThai=Boolean.Parse(RadioButtonList1.SelectedValue)
            };
            return ms;
        }
    }
}