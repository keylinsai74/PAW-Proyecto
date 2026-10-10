using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class InventoryViewModel
{
    public IEnumerable<InventoryDTO> Inventories { get; set; } = new List<InventoryDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}