
using Microsoft.EntityFrameworkCore;
using NidParcAuto.API.Models;

using NidParcAuto.API.Extensions;
using NidParcAuto.Repository.Interfaces;
using NidParcAuto.Repository.Repository;

namespace NidParcAuto.API
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
            services.AddControllers();

            //JWT

            //Acces � la base de donn�es sql server
            //services.AddDbContext<DbNidParcAutoContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnetion"));
            ServiceExtensions.ConfigureSqlServerContext(services, Configuration);
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Gere les injections de dépendances

            //services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));


            //Configuration des services personalis�s
            //services.ConfigureRepositoryWrapper();
            ServiceExtensions.ConfigureClientService(services);

            //Swagger
            //services.SwaggerGen();
            ServiceExtensions.SwaggerGen(services);

            //Cors
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("https://localhost:7138",
                                           "http://localhost:3000");
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Expert Auto  Api V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
