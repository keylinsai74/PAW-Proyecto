using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class CategoryViewModel
{
    public IEnumerable<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}