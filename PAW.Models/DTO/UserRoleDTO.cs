using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class UserRoleDTO
{
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    [JsonPropertyName("roldId")]
    public decimal? RoldId { get; set; }

    [JsonPropertyName("userId")]
    public decimal? UserId { get; set; }

    public static UserRoleDTO ConvertFrom(UserRole entity)
    {
        return new UserRoleDTO
        {
            Id = entity.Id,
            RoldId = entity.RoldId,
            UserId = entity.UserId
        };
    }

    public static UserRole ConvertTo(UserRoleDTO dto)
    {
        return new UserRole
        {
            Id = dto.Id,
            RoldId = dto.RoldId,
            UserId = dto.UserId
        };
    }
}