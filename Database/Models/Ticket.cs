namespace Event_Managment_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketType { get; set; } 
        public decimal Price { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }

}
