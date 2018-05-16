using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASSET.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ASSET.WebSite
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
            services.AddMvc();

            //services.AddDbContext<ASSETContext>(options => options.UseSqlServer(connection));
			//services.AddDbContext<ASSETContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Development"), x => x.MigrationsAssembly("ASSET.Data")));

			//services.AddDbContext<ASSETContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Development"), b => b.MigrationsAssembly("ASSET.Data")));
			services.AddDbContext<ASSETContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Development")));
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler(" / Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Login}/{id?}");
            });
        }
    }
}
