// Models/Budget.cs

namespace GoodGovernanceSystem.Api.Models
{
    public class Budget
    {
        public int ID { get; set; }
        public string? Department { get; set; }
        public decimal AllocatedAmount { get; set; }
        public decimal SpentAmount { get; set; }
    }
}
