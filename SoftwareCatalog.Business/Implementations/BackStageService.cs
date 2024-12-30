using Microsoft.Extensions.Logging;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Implementations
{
    public sealed class BackStageService : Base.Service<IBackStageService>, IBackStageService
    {
        private readonly IRequisicaoService _requisicaoService;

        public BackStageService(ILogger<IBackStageService> logger, IRequisicaoService requisicaoService) : base(logger)
        {
            _requisicaoService = requisicaoService;
        }

        public async Task<IEnumerable<ApplicacaoBackStage>> ObterCatalogoBackStage(string owner)
        {
            string uri = $"https://prd-aks-softwarecatalog-api.conectcar.com/api/software/catalog/owners/{owner}/components";

            return await _requisicaoService.GetAsyncToList<ApplicacaoBackStage>(uri);
        }

        public ApplicacaoBackStage BuscaAplicacaoPeloAzureName(IEnumerable<ApplicacaoBackStage> applicacaoBackStage, string azureName)
        {
            return applicacaoBackStage.FirstOrDefault(x =>(x.metadata.labels.azurewebappname ?? string.Empty).ToLower() == azureName.ToLower() ||
                                        (x.metadata.labels.kubernetesdeployment ?? string.Empty).ToLower() == azureName.ToLower() ||
                                        (x.metadata.labels.kubernetesnamespace ?? string.Empty).ToLower() == azureName.ToLower() ||
                                        (x.metadata.labels.catalogoscorename ?? string.Empty).ToLower() == azureName.ToLower() ||
                                        (x.metadata.labels.iaasmachine ?? string.Empty).ToLower() == azureName.ToLower() ||
                                        (x.metadata.labels.linuxconsoleapp ?? string.Empty).ToLower() == azureName.ToLower());
        }

        public string Nome(ApplicacaoBackStage applicacaoBackStage)
        {
            return $"Nome: {applicacaoBackStage.metadata.name}";
        }

        public string RetornaCatalogoBackStageAplicacaoName(ApplicacaoBackStage applicacaoBackStage)
        {
            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.azurewebappname))
                return applicacaoBackStage.metadata.labels.azurewebappname;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.kubernetesdeployment))
                return applicacaoBackStage.metadata.labels.kubernetesdeployment;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.kubernetesnamespace) && applicacaoBackStage.metadata.labels.kubernetesnamespace.Length >= 11)
                return applicacaoBackStage.metadata.labels.kubernetesnamespace;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.catalogoscorename))
                return applicacaoBackStage.metadata.labels.catalogoscorename;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.linuxconsoleapp))
                return applicacaoBackStage.metadata.labels.linuxconsoleapp;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.labels.iaasmachine))
                return applicacaoBackStage.metadata.labels.iaasmachine;

            if (!String.IsNullOrWhiteSpace(applicacaoBackStage.metadata.name))
                return applicacaoBackStage.metadata.name;

            return string.Empty;
        }

    }
}
