using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class UserActionViewModel
{
    public IEnumerable<UserActionDTO> UserActions { get; set; } = new List<UserActionDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}