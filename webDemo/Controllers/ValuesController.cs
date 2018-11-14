using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private string[] lista
        {
            get
            {
                if (System.Web.HttpContext.Current.Application[  "lista"  ] == null)
                {
                    System.Web.HttpContext.Current.Application[   "lista"  ] =
                        new string[] {   "value1"  ,   "value2"   };
                }
                return
                    (string[])System.Web.HttpContext.Current.Application[  "lista"  ];
            }
        }
        public IEnumerable<string> Get()
        {
            return lista;
        }
        public string Get(int id)
        {
            return lista[id];
        }
        public void Post([FromBody]string value)
        {
        }
        public void Put(int id, [FromBody]string value)
        {
            lista[id] = value;
        }
        public void Delete(int id)
        {
        }
    }
}
