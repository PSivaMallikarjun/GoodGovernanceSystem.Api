// Models/Feedback.cs

namespace GoodGovernanceSystem.Api.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public int CitizenID { get; set; }
        public string? FeedbackText { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
