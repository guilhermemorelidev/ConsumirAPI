using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsumirApi;

internal class cep
{
    [JsonPropertyName("CEP")]
    public string Cep { get; set; }
    
    [JsonPropertyName("Cidade")]
    public string cidade { get; set; }
    
    [JsonPropertyName("Estado")]
    public string estado { get; set; }
    
    [JsonPropertyName("Rua")]
    public string rua { get; set; }

    [JsonPropertyName("Nei")]
    public string nei { get; set; }
}