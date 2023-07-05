using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using NidParcAuto.API.Models;
using NidParcAuto.API.Services;
using NidParcAuto.Repository.Interfaces;
using NidParcAuto.Repository.Repository;
using NidParcAuto.Contract.Interfaces;

namespace NidParcAuto.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration Configuration)
        {
            var connection = Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            services.AddDbContext<DbNidParcAutoContext>(options => options.UseSqlServer(connection));
        }
        public static void SwaggerGen (IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NidParcAuto API", Version = "v1" });
            });
        }

        public static void ConfigureClientService(this IServiceCollection services)
        {
            services.AddTransient<ICommuneRepository, CommuneRepository>();
            services.AddTransient<IEnergieRepository, EnergieRepository>();
            services.AddTransient<IServicesAdminisRepository, ServicesAdminisRepository>();
            services.AddTransient<IMarqueRepository, MarqueRepository>();



        }
    }
}
