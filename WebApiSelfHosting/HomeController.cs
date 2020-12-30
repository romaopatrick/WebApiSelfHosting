using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiSelfHosting
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(new {Result = "Bem-vindo à webapi com self-hosting"});
        }
    }
}
