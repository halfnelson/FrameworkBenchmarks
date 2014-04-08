using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebApi
{
    public class TechempowerController: ApiController
    {
        [HttpGet]
        public object Json()
        {
            return new { message = "Hello, World!" };
        }

        [HttpGet]
        public HttpResponseMessage PlainText()
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent("Hello, World!", Encoding.UTF8, "text/plain");
            return resp;
        } 
    }
}
