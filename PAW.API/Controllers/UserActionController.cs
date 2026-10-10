using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserActionController(IUserActionRepository userActionRepository) : ControllerBase
{
    [HttpGet(Name = "GetUserActions")]
    public async Task<IEnumerable<UserActionDTO>> GetAll()
    {
        var items = await userActionRepository.ReadAsync();
        return items.Select(UserActionDTO.ConvertFrom);
    }
}