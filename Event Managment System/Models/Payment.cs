namespace Event_Managment_System.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EventId { get; set; } 
        public Event Event { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; } 
    }

}
