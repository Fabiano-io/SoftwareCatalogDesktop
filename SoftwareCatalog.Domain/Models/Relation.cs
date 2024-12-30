using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCatalog.Domain.Models
{
    public sealed class Relation
    {
        public string type { get; set; }
        public string targetRef { get; set; }
        public Target target { get; set; }
    }
}
