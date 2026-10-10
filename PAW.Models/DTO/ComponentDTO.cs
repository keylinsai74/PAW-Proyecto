using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class ComponentDTO
{
    [JsonPropertyName("id")]
    public decimal Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    public static ComponentDTO ConvertFrom(Component entity)
    {
        return new ComponentDTO
        {
            Id = entity.Id,
            Name = entity.Name,
            Content = entity.Content
        };
    }

    public static Component ConvertTo(ComponentDTO dto)
    {
        return new Component
        {
            Id = dto.Id,
            Name = dto.Name,
            Content = dto.Content
        };
    }
}