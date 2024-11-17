// Models/Citizen.cs

namespace GoodGovernanceSystem.Api.Models
{
    public class Citizen
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Income { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
