using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ComponentController(IComponentRepository componentRepository) : ControllerBase
{
    [HttpGet(Name = "GetComponents")]
    public async Task<IEnumerable<ComponentDTO>> GetAll()
    {
        var items = await componentRepository.ReadAsync();
        return items.Select(ComponentDTO.ConvertFrom);
    }
}