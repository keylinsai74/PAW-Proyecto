using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class PawTaskController : ControllerBase
{
    private readonly IPawTaskService _pawTaskService;

    public PawTaskController(
        IPawTaskService pawTaskService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _pawTaskService = pawTaskService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new PawTaskViewModel
        {
            PawTasks = await _pawTaskService.GetPawTasksAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}