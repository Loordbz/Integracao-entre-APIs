using System.Text.Json.Serialization;

namespace Domain.Models;

public class Endereco
{
    [JsonPropertyName("cep")]
    public string? Cep { get; set; }

    [JsonPropertyName("state")]
    public string? Estado { get; set; }

    [JsonPropertyName("city")]
    public string? Cidade { get; set; }

    [JsonPropertyName("neighborhood")]
    public string? Bairro { get; set; }

    [JsonPropertyName("street")]
    public string? Rua { get; set; }

    [JsonPropertyName("service")]
    public string? Servico { get; set; }
}
