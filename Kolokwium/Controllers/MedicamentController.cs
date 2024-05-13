using Kolokwium.Models;
using Microsoft.AspNetCore.Mvc;
using Kolokwium.Services;

namespace Kolokwium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IMedicamentService _medicamentService;

        public MedicamentController(IMedicamentService medicamentService)
        {
            _medicamentService = medicamentService;
        }

        [HttpGet("{idMedicament}")]
        public IActionResult GetMedicament([FromQuery] int id)
        {
            try
            {
                IEnumerable<MedicamentDTO> medicaments = _medicamentService.GetMedicament(id);
                return Ok(medicaments)
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}