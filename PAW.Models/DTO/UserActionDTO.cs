using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class UserActionDTO
{
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    public static UserActionDTO ConvertFrom(UserAction entity)
    {
        return new UserActionDTO
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description
        };
    }

    public static UserAction ConvertTo(UserActionDTO dto)
    {
        return new UserAction
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description
        };
    }
}