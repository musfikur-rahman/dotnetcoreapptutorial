using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using dotnetcoreapptutorial.Models;
using Microsoft.Extensions.Configuration;

namespace dotnetcoreapptutorial
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddXmlSerializerFormatters();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            //services.AddControllers(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            /*
            app.UseMvcWithDefaultRoute();

            app.UseEndpoints(async (endpoints) =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id}");
            }); 
            */
        }
    }
}
