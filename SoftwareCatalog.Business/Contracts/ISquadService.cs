using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Contracts
{
    public interface ISquadService
    {
        Task<IEnumerable<Squad>> ObterSquads();

        IEnumerable<SquadSimplificada> RetornaListaSquadSimplificada(IEnumerable<Squad> squads);
    }
}
