using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Services;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Xml.Linq;

namespace Event_Managment_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)//Dependency Injection
        {
            _service =service;
        }
        [HttpPost]
        [ActionName("AddUsers")]
        public List<User> AddUser([FromBody] User newuser)
        {
            _service.AddUser(newuser);
            return _service.GetAllUsers();
        }

        [HttpGet]
        [ActionName("GetUsers")]
        public List<User> GetUsers()
        {
            return _service.GetAllUsers();
        }


        //[HttpDelete]
        //[ActionName("DeleteUsers")]
        //public ActionResult DeleteUsers([FromBody] User newuser)
        //{
        //    users.Remove(newuser);
        //    return Ok(newuser);
        //}

        //[HttpDelete]
        //[ActionName("DeleteUserById")]
        //public ActionResult DeleteUserById([FromBody] User newuser)
        //{

        //}
    }
}
