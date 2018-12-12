using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ThuVien
{
    public class chucnag : ApiController
    {
        string connect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        int sl;
        bool trangThai;
        public bool DangNhapAdmin(string tk, string mk)//Đăng nhập trang quản trị
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from DangNhap where TaiKhoan=@ma and MatKhau=@mk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", tk);
                cmd.Parameters.AddWithValue("@mk", mk);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr.Read();
            }
        }
        public bool DangNhap(string tk, string mk)//Đăng nhập trang thư viện
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from SinhVien where MaSV=@ma and MatKhau=@mk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma",tk);
                cmd.Parameters.AddWithValue("@mk", mk);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr.Read();
            }
        }
        public DataTable GetTacGia()//Lấy thông tin tác giả
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from TacGia";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetNhaXuatBan()//Lấy thông tin nhà xuất bản
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from NhaXuatBan";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetLoaiSach()//Lấy thông tin loại sách
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from LoaiSach";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllSach()//Lấy tất cả sách trong csdl
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select MaSach,TenSach,NhaXuatBan.TenNhaXB,MoTa,TenLoaiSach,TenTacGia,SoLuong from Sach,NhaXuatBan,LoaiSach,TacGia where Sach.MaNhaXB=NhaXuatBan.MaNhaXB and Sach.MaLoai=LoaiSach.MaLoai and Sach.MaTacGia=TacGia.MaTacGia";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllSachByTacGia(string ma)//Lấy sách theo mã tác giả
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select MaSach,TenSach,NhaXuatBan.TenNhaXB,MoTa,TenLoaiSach,TenTacGia,SoLuong from Sach,NhaXuatBan,LoaiSach,TacGia where Sach.MaNhaXB=NhaXuatBan.MaNhaXB and Sach.MaLoai=LoaiSach.MaLoai and Sach.MaTacGia=TacGia.MaTacGia and Sach.MaTacGia=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllSachByLoaiSach(string ma)//Lấy sách theo mã loại sách
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select MaSach,TenSach,NhaXuatBan.TenNhaXB,MoTa,TenLoaiSach,TenTacGia,SoLuong from Sach,NhaXuatBan,LoaiSach,TacGia where Sach.MaNhaXB=NhaXuatBan.MaNhaXB and Sach.MaLoai=LoaiSach.MaLoai and Sach.MaTacGia=TacGia.MaTacGia and LoaiSach.MaLoai=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllSachByNhaXuatBan(string ma)//Lấy sách theo mã nhà xuất bản
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select MaSach,TenSach,NhaXuatBan.TenNhaXB,MoTa,TenLoaiSach,TenTacGia,SoLuong from Sach,NhaXuatBan,LoaiSach,TacGia where Sach.MaNhaXB=NhaXuatBan.MaNhaXB and Sach.MaLoai=LoaiSach.MaLoai and Sach.MaTacGia=TacGia.MaTacGia and Sach.MaNhaXB=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllSachByTen(string ma)//Lấy sách theo tên
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = string.Format("select MaSach,TenSach,NhaXuatBan.TenNhaXB,MoTa,TenLoaiSach,TenTacGia,SoLuong from Sach,NhaXuatBan,LoaiSach,TacGia where Sach.MaNhaXB=NhaXuatBan.MaNhaXB and Sach.MaLoai=LoaiSach.MaLoai and Sach.MaTacGia=TacGia.MaTacGia and TenSach like '%{0}%'",ma);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool InsertMuonSach(muonsach ms)//Thêm lịch sử mượn sách
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "insert into MuonSach(MaSV,MaSach,SoLuong,NgayMuon,NgayTra,TrangThai) values(@masv,@masach,@sl,@ngaymuon,@ngaytra,@trangthai)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masach",ms.MaSach);
                cmd.Parameters.AddWithValue("@masv", ms.MaSV);
                cmd.Parameters.AddWithValue("@sl", ms.SoLuong);
                cmd.Parameters.AddWithValue("@ngaymuon", ms.NgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", ms.NgayTra);
                cmd.Parameters.AddWithValue("@trangthai", ms.TrangThai);
                conn.Open();
                int count = (int)cmd.ExecuteNonQuery();
                return count >= 1;
            }
        }
        public bool CheckMuonSach(muonsach ms)//Kiểm tra sách muốn mượn đã có trong lịch sử mượn?
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from MuonSach where MaSV=@maSV and MaSach=@maSach and TrangThai=0 and NgayMuon=@ngaymuon and NgayTra=@ngaytra";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSV", ms.MaSV);
                cmd.Parameters.AddWithValue("@maSach", ms.MaSach);
                cmd.Parameters.AddWithValue("@ngaymuon", ms.NgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", ms.NgayTra);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr.Read();
            }
        }
        public bool GetTrangThaiMuonSach(string maSV, string maSach)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from MuonSach where MaSV=@maSV and MaSach=@maSach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSV", maSV);
                cmd.Parameters.AddWithValue("@maSach", maSach);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    trangThai = (bool)dr["TrangThai"];
                }
                return trangThai;
            }
        }
        public bool UpdateMuonSach(muonsach ms)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update MuonSach set SoLuong=SoLuong+@sl where MaSV=@maSV and MaSach=@maSach and NgayMuon=@ngaymuon and NgayTra=@ngaytra";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSV", ms.MaSV);
                cmd.Parameters.AddWithValue("@maSach", ms.MaSach);
                cmd.Parameters.AddWithValue("@sl", ms.SoLuong);
                cmd.Parameters.AddWithValue("@ngaymuon", ms.NgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", ms.NgayTra);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                return count >= 1;
            }
        }
        public bool CheckSoLuongSach(string ma, int soLuong)
        { 
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select * from Sach where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sl = (int)dr["SoLuong"];
                }
                return soLuong<=sl;
            }
        }
        public bool UpdateSoLuongSach(string ma, int soLuong)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update Sach set SoLuong=SoLuong-@sl where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@sl", soLuong);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                return count >= 1;
            }
        }
        public DataTable GetMuonSachBySV(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                //string sql = "select MuonSach.MaSach,TenSach,MuonSach.SoLuong,NgayMuon,NgayTra,(case TrangThai when 'true' then N'Đã trả' else N'Đang mượn' end) as TrangThai from MuonSach,Sach where MuonSach.MaSach=Sach.MaSach and MaSV=@ma";
                string sql = "select MuonSach.MaSach,TenSach,MuonSach.SoLuong,convert(char(20),NgayMuon,105),convert(char(20),NgayTra,105),(case TrangThai when 'true' then N'Đã trả' else N'Đang mượn' end) as TrangThai from MuonSach,Sach where MuonSach.MaSach=Sach.MaSach and MaSV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllMuonSach()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                //string sql = "select MuonSach.MaSach,TenSach,MuonSach.SoLuong,NgayMuon,NgayTra,(case TrangThai when 'true' then N'Đã trả' else N'Đang mượn' end) as TrangThai from MuonSach,Sach where MuonSach.MaSach=Sach.MaSach";
                string sql = "select MuonSach.MaSach,TenSach,MuonSach.SoLuong,convert(char(20),NgayMuon,105),convert(char(20),NgayTra,105),(case TrangThai when 'true' then N'Đã trả' else N'Đang mượn' end) as TrangThai from MuonSach,Sach where MuonSach.MaSach=Sach.MaSach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool UpdateTinhTrangMuonSach(string ma, string maSach, string ngayMuon, string ngayTra)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update MuonSach set TrangThai=1 where MaSach=@maSach and MaSV=@ma and NgayMuon=@ngaymuon and NgayTra=@ngaytra";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@maSach", maSach);
                cmd.Parameters.AddWithValue("@ngaymuon", ngayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", ngayTra);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                return count >= 1;
            }
        }
        public bool UpdateSoLuongSachTra(string ma, int soLuong)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "update Sach set SoLuong=SoLuong+@sl where MaSach=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@sl", soLuong);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                return count >= 1;
            }
        }
        public DataTable LayLichSuMuonSachByTrangThai(string ma, bool trangThai)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string sql = "select MuonSach.MaSach,TenSach,MuonSach.SoLuong,NgayMuon,NgayTra,(case TrangThai when 'true' then N'Đã trả' else N'Đang mượn' end) as TrangThai from MuonSach,Sach where MuonSach.MaSach=Sach.MaSach and MaSV=@ma and TrangThai=@trangthai";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@trangthai", trangThai);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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