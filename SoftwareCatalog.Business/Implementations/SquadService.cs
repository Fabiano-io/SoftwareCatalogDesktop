using Microsoft.Extensions.Logging;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Implementations
{
    public sealed class SquadService : Base.Service<ISquadService>, ISquadService
    {
        private readonly IRequisicaoService _requisicaoService;

        public SquadService(ILogger<ISquadService> logger, IRequisicaoService requisicaoService) : base(logger)
        {
            _requisicaoService = requisicaoService;
        }

        public async Task<IEnumerable<Squad>> ObterSquads()
        {
            string uri = $"https://prd-aks-softwarecatalog-api.conectcar.com/api/software/catalog/groups";

            return await _requisicaoService.GetAsyncToList<Squad>(uri);
        }

        public IEnumerable<SquadSimplificada> RetornaListaSquadSimplificada(IEnumerable<Squad> squads)
        {
            return  squads.Where(x => x.metadata.name.ToString() != String.Empty)
                .Select(z => new { z.metadata.name, z.spec.profile.displayName })
                .OrderBy(i => i.displayName)
                .Select(x => new SquadSimplificada { Name = x.name, DisplayName = x.displayName }).ToList();            
        }
    }
}
