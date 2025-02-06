using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event_Managment_System.Models;

namespace Database
{
    public class data
    {
        public static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com", PasswordHash = "hashed123", Role = "Organizer" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com", PasswordHash = "hashed456", Role = "Attendee" }
        };
    }
}
