using System.Text.Json.Serialization;

namespace CalculoGanhoCapital.Model
{
    public class Tax
    {
        [JsonPropertyName("Tax")]
        public double TaxCalculate { get; set; }
    }
}
