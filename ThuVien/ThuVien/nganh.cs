using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLThuVien
{
    public class nganh : ApiController
    {
        string maNganh;
        string tenNganh;
        int soTinChi;
        int soHK;
        string maKhoa;
        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }
        public int SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }
        public int SoHK
        {
            get { return soHK; }
            set { soHK = value; }
        }
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
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