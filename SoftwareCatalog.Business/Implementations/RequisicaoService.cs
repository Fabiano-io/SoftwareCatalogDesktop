using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SoftwareCatalog.Business.Contracts;
using SoftwareCatalog.Domain.Exceptions;
using System.Net.Http.Headers;

namespace SoftwareCatalog.Business.Implementations
{
    public sealed class RequisicaoService : Base.Service<IRequisicaoService>, IRequisicaoService
    {
        public RequisicaoService(ILogger<IRequisicaoService> logger) : base(logger)
        {

        }

        public async Task<IEnumerable<TResponse>> GetAsyncToList<TResponse>(string uri, String token = "")
        {
            using (var client = new HttpClient())
            {
                if (@String.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.GetAsync(uri);

                return await TratarRetornoToList<TResponse>(response);             
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string uri, String token = "")
        {
            using (var client = new HttpClient())
            {
                if (@String.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.GetAsync(uri);

                return await TratarRetorno<TResponse>(response);
            }
        }

        public async Task<TResponse> DeleteAsync<TResponse>(string uri, String token = "")
        {
            using (var client = new HttpClient())
            {
                if (@String.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.DeleteAsync(uri);

                return await TratarRetorno<TResponse>(response);
            }
        }

        public async Task<TResponse> PostAsync<TResponse>(string uri, String token = "")
        {
            using (var client = new HttpClient())
            {
                if (@String.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.PostAsync(uri, null);

                return await TratarRetorno<TResponse>(response);
            }
        }

        public async Task<IEnumerable<TResponse>> TratarRetornoToList<TResponse>(HttpResponseMessage response)
        {
            try
            {       
                return JsonConvert.DeserializeObject<IEnumerable<TResponse>>(await response.Content.ReadAsStringAsync());
                
            }
            catch (Exception)
            {
                throw new DomainException($"HttpStatusCode: {response.StatusCode} | Erro na chamada {response.RequestMessage.RequestUri.OriginalString} | Content : {response.RequestMessage.Content?.ReadAsStringAsync().Result}");
            }
        }

        public async Task<TResponse> TratarRetorno<TResponse>(HttpResponseMessage response)
        {
            try
            {
                return JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());

            }
            catch (Exception)
            {
                throw new DomainException($"HttpStatusCode: {response.StatusCode} | Erro na chamada {response.RequestMessage.RequestUri.OriginalString} | Content : {response.RequestMessage.Content?.ReadAsStringAsync().Result}");
            }
        }
    }
}
