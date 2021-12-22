using System;
using Microsoft.AspNetCore.Mvc;

namespace MVCStudy.Controllers
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("hello")]
        public string GetHello()
        {
            return "Hello World!";
        }
    }
}
