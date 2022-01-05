using AspectCore.DynamicProxy;
using System;
using System.Threading.Tasks;


namespace StudentDemo.Atrributes
{
    public class CustomInterceptorAttribute : AbstractInterceptorAttribute
    {
        public async override Task Invoke(AspectContext context, AspectDelegate next)
        {
            Console.WriteLine("-----Hello World-----");
            await next(context);
        }
    }
}