using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Robo.Services.Domain.Interfaces;
using Robo.Services.Domain.Repository;
using Robo.Services.Infra.Context;
using Robo.Services.Infra.Repository;
using Robo.Services.Service.Competidores;
using Robo.Services.Service.Corrida;

namespace Robo.Services.Api
{
    public class Startup
    {

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDependenciesService(services);


            var connectionString = Configuration["dbContextSettings:ConnectionString"];
            services.AddDbContext<RoboContext>(options => options.UseNpgsql(connectionString, b => b.MigrationsAssembly("Robo.Services.Api")), ServiceLifetime.Singleton );

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:8080").AllowAnyMethod().AllowAnyHeader();
                                  });
            });

            services.AddControllers();
            services.AddHttpContextAccessor();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }

        public static void ConfigureDependenciesService(IServiceCollection services)
        {
            // Transient, create a new instance by use
            services.AddScoped(typeof(IBaseInterface<>), typeof(BaseRepository<>));
            services.AddTransient<IHead, HeadService>();
            services.AddTransient<IArm, ArmService>();
            services.AddTransient<IHeadRepository, HeadRepository>();
            services.AddTransient<IArmRepository, ArmRepository>();
        }
    }
}
