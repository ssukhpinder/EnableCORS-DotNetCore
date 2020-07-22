using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnableCORS_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("CorsPolicyAllHosts")]    //CORS at specific Controller level
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {

        }

        [HttpGet]
        [Route("get")]
        //[EnableCors("CorsPolicyAllHosts")]    //CORS at specific ROUTE level
        public string Get()
        {
            return "Hello World";
        }
    }
}
