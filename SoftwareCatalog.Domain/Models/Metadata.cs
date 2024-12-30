using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCatalog.Domain.Models
{
    public sealed class Metadata
    {
        public string @namespace { get; set; }
        public string description { get; set; }
        public Annotations annotations { get; set; }
        public List<string> tags { get; set; }
        public Labels labels { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public List<Link> links { get; set; }
    }
}
