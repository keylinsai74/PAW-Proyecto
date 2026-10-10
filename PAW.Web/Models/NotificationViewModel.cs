using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class NotificationViewModel
{
    public IEnumerable<NotificationDTO> Notifications { get; set; } = new List<NotificationDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}