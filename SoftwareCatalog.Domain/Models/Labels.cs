using Newtonsoft.Json;

namespace SoftwareCatalog.Domain.Models
{
    public sealed class Labels
    {
        [JsonProperty("applicationinsights/id")]
        public string applicationinsightsid { get; set; }

        [JsonProperty("azure/webappname")]
        public string azurewebappname { get; set; }

        [JsonProperty("applicationinsights/cloudrolename")]
        public string applicationinsightscloudrolename { get; set; }

        [JsonProperty("kubernetes/namespace")]
        public string kubernetesnamespace { get; set; }

        [JsonProperty("kubernetes/deployment")]
        public string kubernetesdeployment { get; set; }

        [JsonProperty("linux/consoleapp")]
        public string linuxconsoleapp { get; set; }

        [JsonProperty("catalogoscore/name")]
        public string catalogoscorename { get; set; }

        [JsonProperty("log/database")]
        public string logdatabase { get; set; }
                
        [JsonProperty("kubernetes/deployment-ccar-completo")]
        public string kubernetesdeploymentccarcompleto { get; set; }

        [JsonProperty("kubernetes/deployment-ccar-empresarial")]
        public string kubernetesdeploymentccarempresarial { get; set; }

        [JsonProperty("kubernetes/deployment-ccar-compartilhado")]
        public string kubernetesdeploymentccarcompartilhado { get; set; }

        [JsonProperty("kubernetes/deployment-parceiro-porto")]
        public string kubernetesdeploymentparceiroporto { get; set; }

        [JsonProperty("kubernetes/deployment-parceiro-mp")]
        public string kubernetesdeploymentparceiromp { get; set; }

        [JsonProperty("kubernetes/deployment-parceiro-compartilhado")]
        public string kubernetesdeploymentparceirocompartilhado { get; set; }

        [JsonProperty("key/vault")]
        public string keyvault { get; set; }

        [JsonProperty("ambiente/id")]
        public string ambienteid { get; set; }

        [JsonProperty("azure/serviceplan")]
        public string azureserviceplan { get; set; }

        [JsonProperty("iaas/machine")]
        public string iaasmachine { get; set; }


    }
}
