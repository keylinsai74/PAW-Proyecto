using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class RoleController : ControllerBase
{
    private readonly IRoleService _roleService;

    public RoleController(
        IRoleService roleService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _roleService = roleService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new RoleViewModel
        {
            Roles = await _roleService.GetRolesAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}