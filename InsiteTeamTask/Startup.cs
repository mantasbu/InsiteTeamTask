using InsiteTeamTask.MockData;
using InsiteTeamTask.Repositories.AttendanceRepo;
using InsiteTeamTask.Repositories.EventRepo;
using InsiteTeamTask.Repositories.GameRepo;
using InsiteTeamTask.Repositories.ProductRepo;
using InsiteTeamTask.Repositories.SeasonRepo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InsiteTeamTask
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IDataService, MockDataService>();

            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISeasonRepository, SeasonRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
