﻿using GestionMateriales.Mvc.Identity;
using GestionMateriales.Repository.Models;
using GestionMateriales.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestionMateriales.Mvc
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("sgm_usuarios")));

            services.AddDbContext<OficinaTecnicaContext>(options => options.UseMySQL(Configuration.GetConnectionString("sgm_oficinatecnica")));

            services.AddScoped<DbContext, OficinaTecnicaContext>();

            services.AddOficinaTecnicaServices(Configuration);

            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 8; 
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            });

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Administracion/Login");

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
