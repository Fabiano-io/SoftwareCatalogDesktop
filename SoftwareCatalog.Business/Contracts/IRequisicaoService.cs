namespace SoftwareCatalog.Business.Contracts
{
    public interface IRequisicaoService
    {
        Task<IEnumerable<TResponse>> GetAsyncToList<TResponse>(string uri, String token = "");

        Task<TResponse> GetAsync<TResponse>(string uri, String token = "");

        Task<TResponse> DeleteAsync<TResponse>(string uri, String token = "");

        Task<TResponse> PostAsync<TResponse>(string uri, String token = "");
        Task<IEnumerable<TResponse>> TratarRetornoToList<TResponse>(HttpResponseMessage response);

        Task<TResponse> TratarRetorno<TResponse>(HttpResponseMessage response);
    }
}
