using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Real.Data;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Real.Repositories;

namespace Real
{
    public class Startup
    {
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration  configuration)
        {
            this.Configuration = configuration;
        }

        // We generate the service by calling them here
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<RealDbContext>(options => 
                options.UseSqlServer(Configuration["Data:Real:ConnectionStrings"]));

            services.AddTransient<IVilleRepository, VilleRepository>();

            services.AddMvc();
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(options =>
                        {
                            options.MapRoute(
                                name: null,
                                template : "{Villes}/{Index}/{id?}",
                                defaults : new { controller ="Villes", action="Index"}
                                    );

                            options.MapRoute(
                                name: null,
                                template: "{controller}/{action}/{id?}"
                               );
                        }
                );

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("No Middleware found");
            });
        }
    }
}
