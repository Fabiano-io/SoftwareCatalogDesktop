using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;

namespace SoftwareCatalog.Business.Base
{
    public abstract class Service<T>
    {
        protected ILogger<T> _logger;
        protected AsyncRetryPolicy _retryPolicy;
        protected DateTime _dataCorrente;

        protected Service(ILogger<T> logger)
        {
            _retryPolicy = Policy.Handle<Exception>()
                                 .WaitAndRetryAsync(2, retryAttempt =>
                                 {
                                     var timeToWait = TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                                     _logger?.LogError($"Erro na tentativa de atualização do banco de dados. Retentativa {retryAttempt}.");
                                     return timeToWait;
                                 });

            _logger = logger;
        }
    }
}
