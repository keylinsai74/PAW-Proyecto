using PAW.Models.DTO;
using PAW.Web.Services;

namespace PAW.Web.Models;

public class PawTaskViewModel
{
    public IEnumerable<PawTaskDTO> PawTasks { get; set; } = new List<PawTaskDTO>();

    public TipoCambioResponse TipoCambio { get; set; } = new();
}