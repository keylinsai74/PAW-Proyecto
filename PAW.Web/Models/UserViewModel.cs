using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class UserViewModel
{
    public IEnumerable<UserDTO> Users { get; set; } = new List<UserDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}