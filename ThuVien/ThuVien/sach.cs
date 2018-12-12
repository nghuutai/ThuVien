using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLThuVien
{
    public class sach : ApiController
    {
        string maSach;
        string tenSach;
        string maNXB;
        string moTa;
        string maLoai;
        string maTacGia;
        int soLuong;
        public string MaNhaXuatBan
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
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