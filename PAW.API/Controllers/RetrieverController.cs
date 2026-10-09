using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess;
using PAW.DataAccess.Entities;

namespace PAW.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetrieverController(ILogger<RetrieverController> logger, IProductRepository productRepository) : ControllerBase
    {
        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetProducts();
        }
    }
}