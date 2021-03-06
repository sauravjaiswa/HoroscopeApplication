using HoroscopeApplication.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoroscopeApplication.Models;
using Microsoft.EntityFrameworkCore;
using HoroscopeApplication.Services;

namespace HoroscopeApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            SunsignBasicInfoRepository.MapSunsignBasicInfo();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => {
                options.EnableEndpointRouting = false;
            }).AddXmlSerializerFormatters();

            services.AddDbContext<HoroscopeAppDbContext>(option => 
                option.UseSqlServer(Configuration.GetConnectionString("HoroscopeClientDBConnection"))
            );

            services.AddRefitClient<IHoroscopeApiService>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri(Configuration["AztroApi:BaseAddress"]);
                    c.DefaultRequestHeaders.Add("x-rapidapi-host", Configuration["AztroApi:Host"]);
                    c.DefaultRequestHeaders.Add("x-rapidapi-key", Configuration["AztroApi:ApiKey"]);
                    c.Timeout = TimeSpan.FromSeconds(10);
                });

            //services.AddRefitClient<ITestService>()
            //    .ConfigureHttpClient(c =>
            //    {
            //        c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/1");
            //    });

            services.AddScoped<ISunsignRepository, SunsignRepository>();
            services.AddScoped<IHoroscopeRepository, HoroscopeRepository>();
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

                app.UseStatusCodePagesWithRedirects("/Home/Error?code={0}");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseCustomMiddleware();

            app.UseMvcWithDefaultRoute();
        }
    }
}
