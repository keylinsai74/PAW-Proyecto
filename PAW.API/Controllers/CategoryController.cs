using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController(ICategoryRepository categoryRepository) : ControllerBase
{
    [HttpGet(Name = "GetCategories")]
    public async Task<IEnumerable<CategoryDTO>> GetAll()
    {
        var items = await categoryRepository.ReadAsync();
        return items.Select(CategoryDTO.ConvertFrom);
    }

    [HttpGet("{id:int}", Name = "GetCategoryById")]
    public async Task<ActionResult<CategoryDTO>> GetById(int id)
    {
        var item = await categoryRepository.FindAsync(id);
        if (item is null)
            return NotFound();

        return CategoryDTO.ConvertFrom(item);
    }
}