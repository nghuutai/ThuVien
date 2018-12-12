using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLThuVien
{
    public class sinhvien : ApiController
    {
        string maSV;
        string ho;
        string ten;
        string hoTen;
        DateTime ngaySinh;
        bool gioiTinh;
        string noiSinh;
        string maNganh;
        string matKhau;
        public string MaSinhVien
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string NoiSinh
        {
            get { return noiSinh; }
            set { noiSinh = value; }
        }
        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
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