using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCStudy.Models;
using MVCStudy.PostgresSQL;
namespace MVCStudy.Controllers
{
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PersonContext _context;

        public PeopleController(PersonContext context)
        {
            _context = context;
        }

        [HttpGet("people/hello")]
        public void TestConnection()
        {
            Console.WriteLine("---Test Connection---");
        }

        [HttpGet("people/all")]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return _context.person;
        }
    }
}
