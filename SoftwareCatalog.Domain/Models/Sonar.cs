namespace SoftwareCatalog.Domain.Models
{
    public sealed class Sonar
    {
        public string status { get; set; }
        public bool ignoredConditions { get; set; }
        public List<Condition> conditions { get; set; }
        public List<Period> periods { get; set; }
    }
}

public class Condition
{
    public string status { get; set; }
    public string metricKey { get; set; }
    public string comparator { get; set; }
    public int? periodIndex { get; set; }
    public string errorThreshold { get; set; }
    public string actualValue { get; set; }
}

public class Period
{
    public int index { get; set; }
    public string mode { get; set; }
    public DateTime date { get; set; }
    public string parameter { get; set; }
}

