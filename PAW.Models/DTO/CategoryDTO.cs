using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class CategoryDTO
{
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("categoryName")]
    public string? CategoryName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    public static CategoryDTO ConvertFrom(Category entity)
    {
        return new CategoryDTO
        {
            CategoryId = entity.CategoryId,
            CategoryName = entity.CategoryName,
            Description = entity.Description,
            LastModified = entity.LastModified,
            ModifiedBy = entity.ModifiedBy
        };
    }

    public static Category ConvertTo(CategoryDTO dto)
    {
        return new Category
        {
            CategoryId = dto.CategoryId,
            CategoryName = dto.CategoryName,
            Description = dto.Description,
            LastModified = dto.LastModified,
            ModifiedBy = dto.ModifiedBy
        };
    }
}