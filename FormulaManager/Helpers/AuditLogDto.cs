using Newtonsoft.Json;

namespace FormulaManager.Helpers
{
    public class AuditLogBasic
    {
        [JsonProperty(Order = 1)]
        public string LogTime { get; set; }
        [JsonProperty(Order = 2)]
        public string Version { get; set; }
        [JsonProperty(Order = 3)]
        public string ModelType { get; set; }
        [JsonProperty(Order = 4)]
        public string CalculationName { get; set; }
    }
    public class FormulaLog : AuditLogBasic
    {
        [JsonProperty(Order = 5)]
        public string Formula { get; set; }
        [JsonProperty(Order = 6)]
        public string Input { get; set; }
        [JsonProperty(Order = 7)]
        public string Output { get; set; }
    }
    public class FetchedDataLog : AuditLogBasic
    {
        [JsonProperty(Order = 5)]
        public string Input { get; set; }
        [JsonProperty(Order = 6)]
        public string FetchedData { get; set; }
    }
}
