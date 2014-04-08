using System;
using System.Collections.Generic;
using System.Linq;
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
        public object PlainText()
        {
            return "Hello, World!";
        } 
    }
}
