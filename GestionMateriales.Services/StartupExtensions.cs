using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GestionMateriales.Repository;
using GestionMateriales.Services.Contracts;
using GestionMateriales.Services.Implementation;

namespace GestionMateriales.Services
{
    public static class StartupExtentions
    {
        public static void AddOficinaTecnicaServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOficinaTecnicaRepository(configuration);

            services.AddScoped<IPersonalService, PersonalService>();
        }
    }
}
