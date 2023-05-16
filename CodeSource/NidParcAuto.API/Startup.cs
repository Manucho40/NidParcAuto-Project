using Microsoft.EntityFrameworkCore;
using NidParcAuto.Repository; 
using Microsoft.OpenApi.Models;
using NidParcAuto.API.Model;
using NidParcAuto.Contract;

namespace NidParcAuto.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }


        // Cette methode fait appel au Runtime. Utilise cette methode pour ajouter des services au container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Acces � la base de donn�es sql server
            services.AddDbContext<NidParcAutoContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            // Gere les injections de dépendances
            services.AddScoped<IEnergieRepository, EnergieRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NidParcAuto API", Version = "v1" });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "NidParcAuto API v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
