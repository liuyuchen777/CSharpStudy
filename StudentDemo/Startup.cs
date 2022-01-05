using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StudentDemo.Models;
using StudentDemo.Datas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AspectCore.DependencyInjection;
using AspectCore.Extensions.DependencyInjection;
using StudentDemo.Controllers;
using AspectCore.Configuration;
using StudentDemo.Others;
using StudentDemo.Attributes;

namespace StudentDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("Postgres");

            services.ConfigureDynamicProxy();

            Console.WriteLine(connectionString);

            services.AddDbContext<ApplicationContext>(options =>
                options.UseNpgsql(connectionString)
            );

            services.AddControllers();

            services.AddSingleton<GlobalFlag>();
            services.AddScoped<MigrateFilterAttribute>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // InitialDatabase(app);
        }

        public void InitialDatabase(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<ApplicationContext>().Database.Migrate();
            }
        }
    }
}
