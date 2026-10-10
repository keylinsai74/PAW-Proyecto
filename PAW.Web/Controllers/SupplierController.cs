using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class SupplierController : ControllerBase
{
    private readonly ISupplierService _supplierService;

    public SupplierController(
        ISupplierService supplierService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _supplierService = supplierService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new SupplierViewModel
        {
            Suppliers = await _supplierService.GetSuppliersAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}