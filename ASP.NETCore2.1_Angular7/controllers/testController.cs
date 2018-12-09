using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore2._1_Angular7.controllers
{
    [Route("api/[Controller]")]
    public class testController : Controller
    {
        [HttpGet("/api/values")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World", "a", "b", "c", "d" };
        }
    }
}