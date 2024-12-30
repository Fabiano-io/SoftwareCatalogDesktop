namespace SoftwareCatalog.Domain.Models
{
    public sealed class ApplicacaoBackStage
    {
        public Metadata metadata { get; set; }
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public Spec spec { get; set; }
        public List<Relation> relations { get; set; }
        public int qtdReferences { get; set; }
        public string dataExtracao { get; set; }
    }
}
