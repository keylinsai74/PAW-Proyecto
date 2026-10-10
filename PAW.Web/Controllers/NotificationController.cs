using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(
        INotificationService notificationService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new NotificationViewModel
        {
            Notifications = await _notificationService.GetNotificationsAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}