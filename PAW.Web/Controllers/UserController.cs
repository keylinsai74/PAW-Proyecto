using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(
        IUserService userService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new UserViewModel
        {
            Users = await _userService.GetUsersAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}