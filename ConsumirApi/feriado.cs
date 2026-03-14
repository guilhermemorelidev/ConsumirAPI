using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace ConsumirApi
{
    internal class feriado 
    {
        [JsonPropertyName("date")]
        public DateTime Date {  get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }
}
