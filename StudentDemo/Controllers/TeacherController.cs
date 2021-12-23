using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDemo.Datas;
using StudentDemo.Models;
using StudentDemo.Atrributes;
using StudentDemo.Attributes;

namespace StudentDemo.Controllers
{
    [ServiceFilter(typeof(MigrateFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationContext _context;
        // private bool _flag;

        public TeacherController(ApplicationContext context)
        {
            _context = context;
            // _flag = false;
        }

        //private void InitialDatabase()
        //{
        //    if (_flag == false)
        //    {
        //        _context.Database.Migrate();
        //        _flag = true;
        //    }
        //}

        // GET: api/Teacher
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            // InitialDatabase();

            return await _context.Teachers.ToListAsync();
        }

        // GET: api/Teacher/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            // InitialDatabase();

            var teacher = await _context.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // PUT: api/Teacher/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        {
            // InitialDatabase();

            if (id != teacher.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Teacher
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        {
            // InitialDatabase();

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);
        }

        // DELETE: api/Teacher/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
        {
            // InitialDatabase();

            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        private bool TeacherExists(int id)
        {
            // InitialDatabase();

            return _context.Teachers.Any(e => e.Id == id);
        }
    }

    //public class MigrateAttribute : AbstractInterceptorAttribute
    //{
    //    private bool _flag = false;
    //    [FromServiceContext]
    //    private readonly ApplicationContext _context;

    //    public async override Task Invoke(AspectContext context, AspectDelegate next)
    //    {
    //        Console.WriteLine("Invoking"); // We are in aspect
    //        if (_flag == false)
    //        {
    //            _context.Database.Migrate();
    //            _flag = true;
    //        }
    //        await next(context); // Run the function
    //    }
    //}

}
