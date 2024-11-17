// Controllers/FeedbackController.cs
using GoodGovernanceSystem.Api.Data;
using GoodGovernanceSystem.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GoodGovernanceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly GovernanceContext _context;

        public FeedbackController(GovernanceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SubmitFeedback([FromBody] Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
            return Ok(feedback);
        }

        [HttpGet]
        public IActionResult GetFeedbacks()
        {
            return Ok(_context.Feedbacks.ToList());
        }
    }
}
