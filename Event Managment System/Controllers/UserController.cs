using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;

    namespace Event_Managment_System.Controllers
    {
        [Route("api/user")]
        [ApiController]
        public class UserController : ControllerBase
        {
            // Static data, referencing the User model
            private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com", PasswordHash = "hashed123", Role = "Organizer" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com", PasswordHash = "hashed456", Role = "Attendee" }
        };

            [HttpGet("getUsers")]
            public ActionResult<List<User>> GetUsers()
        {
            List<User> user = users.Select(x => new User
            {Id=x.Id,Name=x.Name,Email=x.Email, PasswordHash = x.PasswordHash,Role= x.Role }).ToList();
            return Ok(user);
        }
        }
    }
