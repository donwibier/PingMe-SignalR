using DevExtreme.AspNet.Data;
using DXServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DXServer.Controllers
{
    public class ProductGroupsApiController : ApiController
    {
        private DXServerContext db = new DXServerContext();

        // GET: api/ProductGroupsApi
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            //return null;
            return Request.CreateResponse(DataSourceLoader.Load(db.ProductGroups, loadOptions));
        }
        // GET: api/ProductGroupsApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductGroupsApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductGroupsApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductGroupsApi/5
        public void Delete(int id)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
