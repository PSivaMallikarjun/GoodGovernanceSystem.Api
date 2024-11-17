// Controllers/BudgetsController.cs
using GoodGovernanceSystem.Api.Data;
using GoodGovernanceSystem.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace GoodGovernanceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly GovernanceContext _context;

        public BudgetsController(GovernanceContext context)
        {
            _context = context;
        }

        [HttpPost("allocate")]
        public IActionResult AllocateBudget([FromBody] Budget budget)
        {
            _context.Budgets.Add(budget);
            _context.SaveChanges();
            return Ok(budget);
        }

        [HttpGet]
        public IActionResult GetBudgets()
        {
            return Ok(_context.Budgets.ToList());
        }
    }
}
