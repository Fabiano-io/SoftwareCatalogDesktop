namespace SoftwareCatalog.Domain.Models
{
    public sealed class Link
    {
        public string url { get; set; }
        public string title { get; set; }
        public string ?type { get; set; }
    }
}
