namespace Event_Managment_System.Models
{
    public class Event
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public required int OrganizerId { get; set; } 
        public required User Organizer { get; set; }
    }
}
