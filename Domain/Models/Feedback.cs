namespace Event_Managment_System.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign Key
        public User User { get; set; }
        public int EventId { get; set; } // Foreign Key
        public Event Event { get; set; }
        public int Rating { get; set; } // 1-5 stars
        public string Comments { get; set; }
    }

}
