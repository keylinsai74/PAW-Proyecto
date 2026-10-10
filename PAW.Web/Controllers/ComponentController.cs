using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class ComponentController : ControllerBase
{
    private readonly IComponentService _componentService;

    public ComponentController(
        IComponentService componentService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _componentService = componentService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new ComponentViewModel
        {
            Components = await _componentService.GetComponentsAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}