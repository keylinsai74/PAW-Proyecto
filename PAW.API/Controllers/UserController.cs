using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserRepository userRepository) : ControllerBase
{
    [HttpGet(Name = "GetUsers")]
    public async Task<IEnumerable<UserDTO>> GetAll()
    {
        var items = await userRepository.ReadAsync();
        return items.Select(UserDTO.ConvertFrom);
    }

    [HttpGet("{id:int}", Name = "GetUserById")]
    public async Task<ActionResult<UserDTO>> GetById(int id)
    {
        var item = await userRepository.FindAsync(id);
        if (item is null)
            return NotFound();

        return UserDTO.ConvertFrom(item);
    }
}