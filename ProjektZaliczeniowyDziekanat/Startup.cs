using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ProjektZaliczeniowyDziekanat.DAL.Contexts;
using Microsoft.OpenApi.Models;
using ProjektZaliczeniowyDziekanat.Configuration;
using ProjektZaliczeniowyDziekanat.Interfaces;
using ProjektZaliczeniowyDziekanat.Services;
using System;

namespace ProjektZaliczeniowyDziekanat
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
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "AppMVC API", Version = "v1" });
            });

            services.AddScoped<IObslugaStudent, ObslugaStudent>();
            services.AddScoped<IObslugaWykladowca, ObslugaWykladowca>();
            services.AddScoped<IObslugaAccount, ObslugaAccount>();
            services.AddScoped<IObslugaAdmin, ObslugaAdmin>();

            services.AddDbContext<DziekanatContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            SwaggerOptions swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
            app.UseSwagger(option => { option.RouteTemplate = swaggerOptions.JsonRoute; });
            app.UseSwaggerUI(option => { option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description); });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=UserRole}");
            });
        }
    }
}
