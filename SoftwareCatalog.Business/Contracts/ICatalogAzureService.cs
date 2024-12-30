using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Contracts
{
    public interface ICatalogAzureService
    {
        Task<IEnumerable<AplicacaoAzure>> ObterCatalogoAzure(string owner);

        bool EstaNoCatalogoAzure(IEnumerable<AplicacaoAzure> applicacaoAzure, string backStageName);

        Task<bool> ExcluirDoCatalogoAzure(string squad, string aplicacao);

        Task<bool> CadastraNoCatalogoAzure(string squad, string nomeAplicacao, string tipoAplicacao);
    }
}
