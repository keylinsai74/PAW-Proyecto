using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class UserActionController : ControllerBase
{
    private readonly IUserActionService _userActionService;

    public UserActionController(
        IUserActionService userActionService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _userActionService = userActionService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new UserActionViewModel
        {
            UserActions = await _userActionService.GetUserActionsAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}