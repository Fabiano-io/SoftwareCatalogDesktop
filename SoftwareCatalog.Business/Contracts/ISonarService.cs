using SoftwareCatalog.Domain.Models;

namespace SoftwareCatalog.Business.Contracts
{
    public interface ISonarService
    {
        Task<Sonar> ObterDadosSonar(string projectkey);
        string RetornaProjectKey(string sonarqubeorgprojectkey);
    }
}
