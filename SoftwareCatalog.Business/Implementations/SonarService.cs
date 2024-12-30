using Microsoft.Extensions.Logging;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Implementations
{
    public sealed class SonarService : Base.Service<ISonarService>, ISonarService
    {
        private readonly IRequisicaoService _requisicaoService;

        public SonarService(ILogger<ISonarService> logger, IRequisicaoService requisicaoService) : base(logger)
        {
            _requisicaoService = requisicaoService;
        }

        public async Task<Sonar> ObterDadosSonar(string projectkey)
        {
            string uri = $"https://prd-aks-softwarecatalog-api.conectcar.com/api/sonarcloud/projects/{projectkey}/status";

            return await _requisicaoService.GetAsync<Sonar>(uri);
        }

        public string RetornaProjectKey(string sonarqubeorgprojectkey)
        {
            if (String.IsNullOrWhiteSpace(sonarqubeorgprojectkey))
                return String.Empty;

            return sonarqubeorgprojectkey.Replace("default/", "").ToString();
        }
    }
}
