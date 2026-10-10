using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class RoleDTO
{
    [JsonPropertyName("roleId")]
    public int RoleId { get; set; }

    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    public static RoleDTO ConvertFrom(Role entity)
    {
        return new RoleDTO
        {
            RoleId = entity.RoleId,
            RoleName = entity.RoleName
        };
    }

    public static Role ConvertTo(RoleDTO dto)
    {
        return new Role
        {
            RoleId = dto.RoleId,
            RoleName = dto.RoleName
        };
    }
}