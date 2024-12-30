using Microsoft.Extensions.DependencyInjection;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Business.Contracts.Util;
using SoftwareCatalog.Business.Implementations;
using SoftwareCatalog.Business.Implementations.Util;

namespace SoftwareCatalog.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static void Inject(this IServiceCollection services)
        {

            #region Helpers
            services.AddHttpClient();
            #endregion

            #region Services
            services.AddScoped<IBackStageService, BackStageService>();
            services.AddScoped<ICatalogAzureService, CatalogAzureService>();
            services.AddScoped<IRequisicaoService, RequisicaoService>();
            services.AddScoped<ISonarService, SonarService>();
            services.AddScoped<ISquadService, SquadService>();
            services.AddScoped<IUtilService, UtilService>();
            
            #endregion

            #region Repositories
            //services.AddScoped<INegociacaoRepository, NegociacaoRepository>();
            #endregion
        }
    }
}
