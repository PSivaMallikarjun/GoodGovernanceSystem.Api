// Controllers/CitizensController.cs
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using GoodGovernanceSystem.Api.Data;
using GoodGovernanceSystem.Api.Models;


namespace GoodGovernanceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly GovernanceContext _context;

        public CitizensController(GovernanceContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterCitizen([FromBody] Citizen citizen)
        {
            citizen.TaxAmount = CalculateTax(citizen.Income);
            _context.Citizens.Add(citizen);
            await _context.SaveChangesAsync();
            return Ok(citizen);
        }

        [HttpGet]
        public IActionResult GetAllCitizens()
        {
            var citizens = _context.Citizens.ToList();
            return Ok(citizens);
        }

        private decimal CalculateTax(decimal income)
        {
            if (income <= 250000) return 0;
            if (income <= 500000) return income * 0.05M;
            if (income <= 1000000) return income * 0.2M;
            return income * 0.3M;
        }
    }
}
