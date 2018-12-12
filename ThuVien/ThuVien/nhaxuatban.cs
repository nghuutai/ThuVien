using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLThuVien
{
    public class nhaxuatban : ApiController
    {
        string maNXB;
        string tenNXB;
        string diaChi;
        string sDT;
        public string MaNhaXuatBan
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        public string TenNhaXuatBan
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return sDT; }
            set { sDT = value; }
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