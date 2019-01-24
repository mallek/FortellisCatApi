using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fortellisapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace fortellisapi.Controllers
{
    [Route("v2/admin/[controller]")]
    [ApiController]
    public class ActivateController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var response = new Links()
            {
                href = "http://testing.com",
                rel = "TravisRocks",
                method = "CallMe()",
                title = "SuperStar"
            };

            return Ok(response);
        }


    }
}
