using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PawTaskController(IPawTaskRepository pawTaskRepository) : ControllerBase
{
    [HttpGet(Name = "GetPawTasks")]
    public async Task<IEnumerable<PawTaskDTO>> GetAll()
    {
        var items = await pawTaskRepository.ReadAsync();
        return items.Select(PawTaskDTO.ConvertFrom);
    }

    [HttpGet("{id:int}", Name = "GetPawTaskById")]
    public async Task<ActionResult<PawTaskDTO>> GetById(int id)
    {
        var item = await pawTaskRepository.FindAsync(id);
        if (item is null)
            return NotFound();

        return PawTaskDTO.ConvertFrom(item);
    }
}