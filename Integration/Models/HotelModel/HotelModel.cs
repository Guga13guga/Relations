using System.Text.Json.Serialization;

namespace Relations.Integration.Models.HotelModel;

public class HotelModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("featuredImage")]
    public string? FeaturedImage { get; set; }

    public override string ToString()
    {
        return $"Id:{Id};Name:{Name};Address:{Address}; City:{City}";
    }
}
