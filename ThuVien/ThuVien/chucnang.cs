using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace QLThuVien
{
    public class chucnang : ApiController
    {
        string connect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        //Tác Giả
        public bool CheckMaTacGia(string maTacGia)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from TacGia where MaTacGia=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maTacGia);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertTacGia(tacgia tg)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into TacGia values(@ma,@ten)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", tg.MaTacGia);
                cmd.Parameters.AddWithValue("@ten", tg.TenTacGia);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }

        }
        public DataTable GetAllTacGia()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from TacGia";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }

        }
        public tacgia GetTacGiaByID(string maTacGia)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from TacGia where MaTacGia=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maTacGia);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tacgia tg = new tacgia()
                    {
                        MaTacGia=(string)dr["MaTacGia"],
                        TenTacGia=(string)dr["TenTacGia"]
                    };
                    return tg;
                }
                return null;
            }

        }
        public bool UpdateTacGia(tacgia tg)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update TacGia set TenTacGia=@ten where MaTacGia=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", tg.MaTacGia);
                cmd.Parameters.AddWithValue("@ten", tg.TenTacGia);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteTacGia(string maTacGia)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from TacGia where MaTacGia=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maTacGia);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }

        }
        //Loại sách
        public bool CheckMaLoaiSach(string maLoaiSach)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from LoaiSach where MaLoai=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maLoaiSach);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertLoaiSach(loaisach ls)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into LoaiSach values(@ma,@ten)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ls.MaLoai);
                cmd.Parameters.AddWithValue("@ten", ls.TenLoaiSach);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public DataTable GetAllLoaiSach()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from LoaiSach";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }

        }
        public loaisach GetLoaiSachByID(string maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from LoaiSach where MaLoai=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maLoai);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    loaisach ls = new loaisach()
                    {
                        MaLoai = (string)dr["MaLoai"],
                        TenLoaiSach = (string)dr["TenLoaiSach"]
                    };
                    return ls;
                }
                return null;
            }
        }
        public bool UpdateLoaiSach(loaisach ls)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update LoaiSach set TenLoaiSach=@ten where MaLoai=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ls.MaLoai);
                cmd.Parameters.AddWithValue("@ten", ls.TenLoaiSach);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteLoaiSach(string maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from LoaiSach where MaLoai=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maLoai);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        //NHÀ XUẤT BẢN
        public bool CheckMaNhaXuatBan(string maNXB)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from NhaXuatBan where MaNhaXB=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNXB);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertNhaXuatBan(nhaxuatban nxb)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into NhaXuatBan values(@ma,@ten,@dc,@sdt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", nxb.MaNhaXuatBan);
                cmd.Parameters.AddWithValue("@ten", nxb.TenNhaXuatBan);
                cmd.Parameters.AddWithValue("@dc", nxb.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", nxb.SoDienThoai);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public DataTable GetAllNhaXuatBan()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from NhaXuatBan";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }

        }
        public nhaxuatban GetNhaXuatBanByID(string maNXB)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from NhaXuatBan where MaNhaXB=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNXB);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nhaxuatban nxb = new nhaxuatban()
                    {
                        MaNhaXuatBan = (string)dr["MaNhaXB"],
                        TenNhaXuatBan = (string)dr["TenNhaXB"],
                        DiaChi=(string)dr["DiaChi"],
                        SoDienThoai=(string)dr["SDT"]
                    };
                    return nxb;
                }
                return null;
            }
        }
        public bool UpdateNhaXuatBan(nhaxuatban nxb)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update NhaXuatBan set TenNhaXB=@ten,DiaChi=@dc,SDT=@sdt where MaNhaXB=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", nxb.MaNhaXuatBan);
                cmd.Parameters.AddWithValue("@ten", nxb.TenNhaXuatBan);
                cmd.Parameters.AddWithValue("@dc", nxb.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", nxb.SoDienThoai);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteNhaXuatBan(string maNXB)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from NhaXuatBan where MaNhaXB=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNXB);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        //QUẢN LÝ SÁCH
        public bool CheckMaSach(string maSach)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from Sach where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maSach);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertSach(sach s)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into Sach values(@ma,@ten,@manxb,@mota,@maloai,@matacgia,@sl)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", s.MaSach);
                cmd.Parameters.AddWithValue("@ten", s.TenSach);
                cmd.Parameters.AddWithValue("@manxb", s.MaNhaXuatBan);
                cmd.Parameters.AddWithValue("@mota", s.MoTa);
                cmd.Parameters.AddWithValue("@maloai", s.MaLoai);
                cmd.Parameters.AddWithValue("@matacgia", s.MaTacGia);
                cmd.Parameters.AddWithValue("@sl", s.SoLuong);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public DataTable GetAllSach()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from Sach";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
        public sach GetSachByID(string maSach)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from Sach where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maSach);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sach s = new sach()
                    {
                        MaSach=(string)dr["MaSach"],
                        TenSach=(string)dr["TenSach"],
                        MaNhaXuatBan = (string)dr["MaNhaXB"],
                        MoTa=(string)dr["MoTa"],
                        MaLoai=(string)dr["MaLoai"],
                        MaTacGia=(string)dr["MaTacGia"],
                        SoLuong=(int)dr["SoLuong"]
                    };
                    return s;
                }
                return null;
            }
        }
        public bool UpdateSach(sach s)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update Sach set TenSach=@ten,MaNhaXB=@manxb,MoTa=@mt,MaLoai=@maloai,MaTacGia=@matacgia,SoLuong=@sl where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", s.MaSach);
                cmd.Parameters.AddWithValue("@ten", s.TenSach);
                cmd.Parameters.AddWithValue("@manxb", s.MaNhaXuatBan);
                cmd.Parameters.AddWithValue("@mt", s.MoTa);
                cmd.Parameters.AddWithValue("@maloai", s.MaLoai);
                cmd.Parameters.AddWithValue("@matacgia", s.MaTacGia);
                cmd.Parameters.AddWithValue("@sl", s.SoLuong);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteSach(string maSach)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from Sach where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maSach);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        //ĐƠN VỊ
        public bool CheckMaDonVi(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from DonVi where MaDV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertDonVi(donvi dv)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into DonVi values(@ma,@ten,@dc,@sdt,@web)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", dv.MaDonVi);
                cmd.Parameters.AddWithValue("@ten", dv.TenDonVi);
                cmd.Parameters.AddWithValue("@dc", dv.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", dv.SoDienThoai);
                cmd.Parameters.AddWithValue("@web", dv.Website);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public DataTable GetAllDonVi()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from DonVi";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
        public donvi GetDonViByID(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from DonVi where MaDV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    donvi dv = new donvi()
                    {
                        MaDonVi = (string)dr["MaDV"],
                        TenDonVi = (string)dr["TenDV"],
                        DiaChi = (string)dr["DiaChi"],
                        SoDienThoai = (string)dr["SDT"],
                        Website = (string)dr["Website"]
                    };
                    return dv;
                }
                return null;
            }
        }
        public bool UpdateDonVi(donvi dv)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update DonVi set TenDV=@ten,DiaChi=@dc,SDT=@sdt,Website=@web where MaDV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", dv.MaDonVi);
                cmd.Parameters.AddWithValue("@ten", dv.TenDonVi);
                cmd.Parameters.AddWithValue("@dc", dv.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", dv.SoDienThoai);
                cmd.Parameters.AddWithValue("@web", dv.Website);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteDonVi(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from DonVi where MaDV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        //NGÀNH
        public bool CheckMaNganh(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from Nganh where MaNganh=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertNganh(nganh ng)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into Nganh values(@ma,@ten,@stc,@shk,@mk)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ng.MaNganh);
                cmd.Parameters.AddWithValue("@ten", ng.TenNganh);
                cmd.Parameters.AddWithValue("@stc", ng.SoTinChi);
                cmd.Parameters.AddWithValue("@shk", ng.SoHK);
                cmd.Parameters.AddWithValue("@mk", ng.MaKhoa);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public DataTable GetAllNganh()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from Nganh";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
        public nganh GetNganhByID(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from Nganh where MaNganh=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nganh ng = new nganh()
                    {
                        MaNganh = (string)dr["MaNganh"],
                        TenNganh = (string)dr["TenNganh"],
                        SoTinChi = (int)dr["SoTinChi"],
                        SoHK = (int)dr["SoHK"],
                        MaKhoa = (string)dr["MaKhoa"]
                    };
                    return ng;
                }
                return null;
            }
        }
        public bool UpdateNganh(nganh ng)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update Nganh set TenNganh=@ten,SoTinChi=@stc,SoHK=@shk,MaKhoa=@mk where MaNganh=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ng.MaNganh);
                cmd.Parameters.AddWithValue("@ten", ng.TenNganh);
                cmd.Parameters.AddWithValue("@stc", ng.SoTinChi);
                cmd.Parameters.AddWithValue("@shk", ng.SoHK);
                cmd.Parameters.AddWithValue("@mk", ng.MaKhoa);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        public bool DeleteNganh(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "delete from Nganh where MaNganh=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        //TÀI KHOẢN SINH VIÊN
        public bool CheckMaSinhVien(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select count(*) from SinhVien where MaSV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertSinhVien(sinhvien sv)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into SinhVien values(@ma,@ho,@ten,@hoten,@ns,@gt,@noisinh,@manganh,@mk)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", sv.MaSinhVien);
                cmd.Parameters.AddWithValue("@ten", sv.Ten);
                cmd.Parameters.AddWithValue("@ho", sv.Ho);
                cmd.Parameters.AddWithValue("@hoten", sv.HoTen);
                cmd.Parameters.AddWithValue("@ns", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@gt", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
                cmd.Parameters.AddWithValue("@manganh", sv.MaNganh);
                cmd.Parameters.AddWithValue("@mk", sv.MatKhau);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return (count >= 1);
            }
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}