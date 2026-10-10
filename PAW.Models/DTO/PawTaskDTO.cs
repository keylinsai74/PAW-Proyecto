using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class PawTaskDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    public static PawTaskDTO ConvertFrom(global::PAW.Models.Task entity)
    {
        return new PawTaskDTO
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            Status = entity.Status,
            DueDate = entity.DueDate,
            CreatedAt = entity.CreatedAt,
            LastModified = entity.LastModified,
            ModifiedBy = entity.ModifiedBy
        };
    }

    public static global::PAW.Models.Task ConvertTo(PawTaskDTO dto)
    {
        return new global::PAW.Models.Task
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Status = dto.Status,
            DueDate = dto.DueDate,
            CreatedAt = dto.CreatedAt,
            LastModified = dto.LastModified,
            ModifiedBy = dto.ModifiedBy
        };
    }
}