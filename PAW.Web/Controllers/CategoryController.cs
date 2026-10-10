using Microsoft.AspNetCore.Mvc;
using PAW.Web.Models;
using PAW.Web.Services;

namespace PAW.Web.Controllers;

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(
        ICategoryService categoryService,
        IExchangeRateService exchangeRateService)
        : base(exchangeRateService)
    {
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new CategoryViewModel
        {
            Categories = await _categoryService.GetCategoriesAsync(),
            TipoCambio = base.TipoCambio
        };
        return View(viewModel);
    }
}