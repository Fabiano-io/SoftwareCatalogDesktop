using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Contracts
{
    public interface IBackStageService
    {
        Task<IEnumerable<ApplicacaoBackStage>> ObterCatalogoBackStage(string owner);
        ApplicacaoBackStage BuscaAplicacaoPeloAzureName(IEnumerable<ApplicacaoBackStage> applicacaoBackStage, string azureName);

        string Nome(ApplicacaoBackStage applicacaoBackStage);

        string RetornaCatalogoBackStageAplicacaoName(ApplicacaoBackStage applicacaoBackStage);
    }
}
