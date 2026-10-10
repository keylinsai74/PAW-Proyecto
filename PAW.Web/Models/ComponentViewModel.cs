using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class ComponentViewModel
{
    public IEnumerable<ComponentDTO> Components { get; set; } = new List<ComponentDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}