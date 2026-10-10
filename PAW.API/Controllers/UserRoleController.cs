using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRoleController(IUserRoleRepository userRoleRepository) : ControllerBase
{
    [HttpGet(Name = "GetUserRoles")]
    public async Task<IEnumerable<UserRoleDTO>> GetAll()
    {
        var items = await userRoleRepository.ReadAsync();
        return items.Select(UserRoleDTO.ConvertFrom);
    }
}