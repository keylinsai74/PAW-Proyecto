using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class UserRoleViewModel
{
    public IEnumerable<UserRoleDTO> UserRoles { get; set; } = new List<UserRoleDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}