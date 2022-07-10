using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalculoGanhoCapital.Model
{
    public class Operation
    {
        [JsonIgnore]
        public int Seq { get; set; }

        [JsonPropertyName("operation")]
        public string TypeOperation { get; set; }

        [JsonPropertyName("unit-cost")]
        public decimal UnitCost { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonIgnore]
        public decimal Gain { get; set; }

        [JsonIgnore]
        public decimal weightedAverage { get; set; }
    }
}
