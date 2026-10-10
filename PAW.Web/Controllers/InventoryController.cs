using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class InventoryController : ControllerBase
{
    private readonly IInventoryService _inventoryService;

    public InventoryController(
        IInventoryService inventoryService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _inventoryService = inventoryService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new InventoryViewModel
        {
            Inventories = await _inventoryService.GetInventoriesAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}