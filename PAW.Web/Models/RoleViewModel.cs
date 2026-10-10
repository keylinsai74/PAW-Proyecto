using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class RoleViewModel
{
    public IEnumerable<RoleDTO> Roles { get; set; } = new List<RoleDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}