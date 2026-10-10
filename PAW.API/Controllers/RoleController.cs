using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleController(IRoleRepository roleRepository) : ControllerBase
{
    [HttpGet(Name = "GetRoles")]
    public async Task<IEnumerable<RoleDTO>> GetAll()
    {
        var items = await roleRepository.ReadAsync();
        return items.Select(RoleDTO.ConvertFrom);
    }

    [HttpGet("{id:int}", Name = "GetRoleById")]
    public async Task<ActionResult<RoleDTO>> GetById(int id)
    {
        var item = await roleRepository.FindAsync(id);
        if (item is null)
            return NotFound();

        return RoleDTO.ConvertFrom(item);
    }
}