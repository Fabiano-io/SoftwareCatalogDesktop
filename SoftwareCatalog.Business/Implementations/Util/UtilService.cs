using Microsoft.Extensions.Logging;
using SoftwareCatalog.Business.Contracts.Util;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoftwareCatalog.Business.Implementations.Util
{
    public sealed class UtilService : Base.Service<IUtilService>, IUtilService
    {
        public UtilService(ILogger<IUtilService> logger) : base(logger)
        {

        }

        public void OpenUrl(string url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

    }
}
