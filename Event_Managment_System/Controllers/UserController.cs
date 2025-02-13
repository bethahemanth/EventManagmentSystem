using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using static Services.UserService;


namespace Event_Managment_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)//Dependency Injection
        {
            _service = service;
        }

        [HttpPost]
        [ActionName("CreateUser")]
        public string CreateTable()
        {
            return _service.CreateTable();
        }

        [HttpPost]
        [ActionName("AddUser")]
        public string InsertUser([FromBody] User user)
        {
            return _service.InsertUser(user);
        }

        [HttpGet]
        [ActionName("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return _service.GetAllUsers();
        }


        [HttpGet]
        [ActionName("GetUserById")]
        public string GetUserById(int id)
        {
            return _service.GetUserById(id);
        }

        [HttpPost]
        [ActionName("UpdateUserById")]
        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role)
        {
            return _service.UpdateUserById(id, name, email, PasswordHash, Role);
        }


        [HttpDelete]
        [ActionName("DeleteUserById")]
        public string DeleteUserById(int id)
        {
            return _service.DeleteUserById(id);
        }

        [HttpDelete]
        [ActionName("DeleteAllUsers")]
        public string DeleteAllusers()
        {
            return _service.DeleteAllusers();
        }

        [HttpGet]
        [ActionName("GetUsersGroupedByRole")]
        public List<groupbyrole> GroupByRole()
        {
            return _service.GroupByRole();

        }

        [HttpGet]
        [ActionName("GetUsersCountByRole")]
        public List<CountEmployees> _CountEmployees()
        {
            return _service._CountEmployees();
        }

        [HttpGet]
        [ActionName("GetUsersWithinSpecificRole")]
        public List<User> _getUsers(string role)
        {
            return _service._getUsers(role);
        }
}
}
