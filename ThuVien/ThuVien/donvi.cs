using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLThuVien
{
    public class donvi : ApiController
    {
        string maDonVi;
        string tenDonVi;
        string diaChi;
        string SDT;
        string website;
        public string MaDonVi
        {
            get { return maDonVi; }
            set { maDonVi = value; }
        }
        public string TenDonVi
        {
            get { return tenDonVi; }
            set { tenDonVi = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
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