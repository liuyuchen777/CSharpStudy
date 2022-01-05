using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using StudentDemo.Datas;
using StudentDemo.Others;

namespace StudentDemo.Attributes
{
    public class MigrateFilterAttribute : ActionFilterAttribute
    {
        private readonly ApplicationContext _context;
        private readonly GlobalFlag _flag;

        public MigrateFilterAttribute(ApplicationContext context, GlobalFlag flag)
        {
            _context = context;
            _flag = flag;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (_flag.Flag == false)
            {
                Console.WriteLine("---In Attribute---");
                _context.Database.Migrate();
                _flag.Flag = true;
            }
            
            base.OnActionExecuting(context);
        }
    }
}
