using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sample.GetAPI.UnitTest.Controllers
{
    class DemoController : ApiController
    {
        public IHttpActionResult Post([FromUri]string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest();
            else
                return Ok();
        }
    }
}
