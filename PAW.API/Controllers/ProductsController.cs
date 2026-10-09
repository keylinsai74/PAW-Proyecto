using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess;
using PAW.DataAccess.Entities;

namespace PAW.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_productRepository.GetProducts());
        }
    }
}