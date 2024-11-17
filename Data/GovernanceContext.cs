using GoodGovernanceSystem.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodGovernanceSystem.Api.Data
{
    public class GovernanceContext : DbContext
    {
        public DbSet<Citizen>? Citizens { get; set; }
        public DbSet<Budget>? Budgets { get; set; }
        public DbSet<Feedback>? Feedbacks { get; set; }

        public GovernanceContext(DbContextOptions<GovernanceContext> options) : base(options) { }
    }
}