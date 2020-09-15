using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FruitManager.Controllers.Fruit
{
    public class MangoController : FruitsController
    {
        [HttpGet]
        [ActionName("getall")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Mango 1", "Mango 2" };
        }

        [HttpGet]
        [ActionName("getdetails")]
        public string Get(int id)
        {
            return String.Format("Mango {0}", id);
        }

        [HttpPost]
        [ActionName("Add")]
        public IHttpActionResult Post([FromBody] string value)
        {
            return Created("/some/url", String.Format("Mango {0}", value));
        }

        [HttpPut]
        [ActionName("changecolor")]
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            return Ok(String.Format(" Changed Mango {0} : {1}", id, value));
        }

        [HttpDelete]
        [ActionName("remove")]
        public IHttpActionResult Delete(int id)
        {
            return Ok(String.Format("Removed Mango {0}", id));
        }
    }
}
