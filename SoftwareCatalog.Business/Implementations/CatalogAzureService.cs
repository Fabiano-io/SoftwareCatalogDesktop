using Microsoft.Extensions.Logging;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Implementations
{
    public sealed class CatalogAzureService : Base.Service<ICatalogAzureService>, ICatalogAzureService
    {
        private readonly IRequisicaoService _requisicaoService;

        public CatalogAzureService(ILogger<ICatalogAzureService> logger, IRequisicaoService requisicaoService) : base(logger)
        {
            _requisicaoService = requisicaoService;
        }

        public async Task<IEnumerable<AplicacaoAzure>> ObterCatalogoAzure(string owner) =>
            await _requisicaoService.GetAsyncToList<AplicacaoAzure>($"https://prd-aks-softwarecatalog-api.conectcar.com/api/software/catalog/azure/owners/{owner}/aplicacoes");            

        public bool EstaNoCatalogoAzure(IEnumerable<AplicacaoAzure> applicacaoAzure, string backStageName)
        {
            var azure = applicacaoAzure.FirstOrDefault(x => (x.Aplicacao ?? string.Empty).ToLower() == backStageName.ToLower());
            return azure is not null;
        }

        public async Task<bool> ExcluirDoCatalogoAzure(string squad, string aplicacao) => 
            await _requisicaoService.DeleteAsync<bool>($"https://prd-aks-softwarecatalog-api.conectcar.com/api/software/catalog/azure/aplicacoes/{squad}/{aplicacao}");

        public async Task<bool> CadastraNoCatalogoAzure(string nomeSquad, string nomeAplicacao, string tipoAplicacao) =>
            await _requisicaoService.PostAsync<bool>($"https://prd-aks-softwarecatalog-api.conectcar.com/api/software/catalog/azure/aplicacoes?squad={nomeSquad}&aplicacao={nomeAplicacao}&tipoAplicacao={tipoAplicacao}");

    }
}
