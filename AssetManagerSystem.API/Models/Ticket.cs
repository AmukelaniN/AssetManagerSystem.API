namespace AssetManagerSystem.API.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Priority { get; set; } = "Medium";   // Low, Medium, High, Critical

        public string Status { get; set; } = "Open";       // Open, In Progress, Resolved, Closed

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int CreatedByUserId { get; set; }

        public User? CreatedByUser { get; set; }
    }
}
