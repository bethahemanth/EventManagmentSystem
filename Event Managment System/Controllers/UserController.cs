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

        [HttpGet]
        [ActionName("GetUserById")]
        public List<User> GetUserById(int id)
        {
            _service.GetUserById(int id);
            return _service.GetAllUsers();
        }

        //[HttpGet]
        //[ActionName("GetUserById")]
        //public List<User> GetUserById(int id)
        //{
        //    return _service.GetUserById(id);
        //}

        [HttpDelete]
        [ActionName("Deleteusers")]
        public List<User> DeleteUsers()
        {
            _service.DeleteAllUsers();
            return _service.GetAllUsers();
        }

        [HttpDelete]
        [ActionName("DeleteUserById")]
        public List<User> DeleteUserByID(int id)
        {
            _service.DeleteUserByID(id);
            return _service.GetAllUsers();
        }
    }
}
