using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using MobileStore.Data;
using Microsoft.EntityFrameworkCore;
using MobileStore.Data.Repositories;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using System.Configuration;
using ReflectionIT.Mvc.Paging;

namespace MobileStore
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        private IConfigurationRoot _configurationRoot;
        public Startup(IHostEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            //Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Authentication, Identity config
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IMobileRepository, MobileRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddScoped(pwl => ProductWishlist.GetWish(pwl));
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddMvc();
            services.AddPaging();
            services.AddMemoryCache();
            services.AddSession();
            services.AddCoreAdmin();

        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env, ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStatusCodePages();
            app.UseSession();

           
            app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
               name: "mobiledetails",
               pattern: "Mobile/Details/{mobileId?}",
               defaults: new { Controller = "Mobile", action = "Details" });

                endpoints.MapControllerRoute(
                    name: "categoryfilter",
                    pattern: "Mobile/{action}/{category?}",
                    defaults: new { Controller = "Mobile", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            DbInitializer.Seed(serviceProvider);
        }
    }
}
