using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatlogAPI.Controllers
{
    [Route("api/Currency")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        // GET api/currency
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "USD", "NPR", "AUD" };
        }
    }
}
