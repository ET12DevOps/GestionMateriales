using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GestionMateriales.Repository.Contracts;
using GestionMateriales.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionMateriales.Repository
{
    public static class StartupExtentions
    {
        public static void AddOficinaTecnicaRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPersonalRepository, PersonalRepository>();
        }
    }
}
