using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class UserRoleController : ControllerBase
{
    private readonly IUserRoleService _userRoleService;

    public UserRoleController(
        IUserRoleService userRoleService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _userRoleService = userRoleService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new UserRoleViewModel
        {
            UserRoles = await _userRoleService.GetUserRolesAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}