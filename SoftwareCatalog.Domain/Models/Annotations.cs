using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCatalog.Domain.Models
{
    public sealed class Annotations
    {
        [JsonProperty("backstage.io/managed-by-location")]
        public string backstageiomanagedbylocation { get; set; }

        [JsonProperty("backstage.io/managed-by-origin-location")]
        public string backstageiomanagedbyoriginlocation { get; set; }

        [JsonProperty("backstage.io/view-url")]
        public string backstageioviewurl { get; set; }

        [JsonProperty("backstage.io/edit-url")]
        public string backstageioediturl { get; set; }

        [JsonProperty("backstage.io/source-location")]
        public string backstageiosourcelocation { get; set; }

        [JsonProperty("dev.azure.com/project-repo")]
        public string devazurecomprojectrepo { get; set; }

        [JsonProperty("sonarqube.org/project-key")]
        public string sonarqubeorgprojectkey { get; set; }
    }
}
