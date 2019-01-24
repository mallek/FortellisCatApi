using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fortellisapi.Controllers
{
    [Route("example/v1/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "https://orig07.deviantart.net/ca8a/f/2014/219/3/4/purple_cat_by_mrverdi-d7u5m47.jpg", "https://i.etsystatic.com/8355506/d/il/e35f8a/1584385043/il_340x270.1584385043_jaay.jpg?version=0" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
