using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController(INotificationRepository notificationRepository) : ControllerBase
{
    [HttpGet(Name = "GetNotifications")]
    public async Task<IEnumerable<NotificationDTO>> GetAll()
    {
        var items = await notificationRepository.ReadAsync();
        return items.Select(NotificationDTO.ConvertFrom);
    }

    [HttpGet("{id:int}", Name = "GetNotificationById")]
    public async Task<ActionResult<NotificationDTO>> GetById(int id)
    {
        var item = await notificationRepository.FindAsync(id);
        if (item is null)
            return NotFound();

        return NotificationDTO.ConvertFrom(item);
    }
}