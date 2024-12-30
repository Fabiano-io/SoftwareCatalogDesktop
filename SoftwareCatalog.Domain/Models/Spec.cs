using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCatalog.Domain.Models
{
    public sealed class Spec
    {
        public string type { get; set; }
        public string lifecycle { get; set; }
        public string owner { get; set; }
        public object system { get; set; }
        public List<string> dependsOn { get; set; }
        public int qtdDependencies { get; set; }
        public string parent { get; set; }
        public Profile profile { get; set; }
        public List<string> children { get; set; }
    }
}
