using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ThuVien
{
    public class muonsach : ApiController
    {
        string maSV;
        string maCB;
        string maSach;
        int soLuong;
        DateTime ngayMuon;
        DateTime ngayTra;
        bool trangThai;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string MaCB
        {
            get { return maCB; }
            set { maCB = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
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