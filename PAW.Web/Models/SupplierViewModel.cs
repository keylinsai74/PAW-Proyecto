using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class SupplierViewModel
{
    public IEnumerable<SupplierDTO> Suppliers { get; set; } = new List<SupplierDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}