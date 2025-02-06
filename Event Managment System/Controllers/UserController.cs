using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Services;

namespace Event_Managment_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService service;
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com", PasswordHash = "hashed123", Role = "Organizer" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com", PasswordHash = "hashed456", Role = "Attendee" }
        };

        [HttpGet]
        [ActionName("GetUsers")]
        public ActionResult<List<User>> GetUsers()
        {
            List<User> userList = users.Select(x => new User
            {   Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                PasswordHash = x.PasswordHash,
                Role = x.Role
            }).ToList();

            return Ok(userList);
        }
        [HttpPost]
        [ActionName("AddUsers")]
        public ActionResult AddUsers([FromBody] User newuser)
        {
            users.Add(newuser);
            return Ok(newuser);
        }

        [HttpDelete]
        [ActionName("DeleteUsers")]
        public ActionResult DeleteUsers([FromBody] User newuser)
        {
            users.Remove(newuser);
            return Ok(newuser);
        }

        [HttpDelete]
        [ActionName("DeleteUserById")]
        public ActionResult DeleteUserById([FromBody] User newuser)
        {
            User user = users.FirstOrDefault(x => x.Id == newuser.Id);
            if (user == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return Ok(user);
        }
    }
}
