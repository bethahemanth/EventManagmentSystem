using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;
using Services;


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

        //[HttpPost]
        //[ActionName("AddUsers")]
        //public User AddUser([FromBody] User newuser)
        //{
        //    _service.AddUser(newuser);
        //    return newuser;
        //}

        [HttpGet]
        [ActionName("GetUsers")]
        public List<User> GetUsers()
        {
            return _service.GetAllUsers();
        }

        [HttpGet]
        [ActionName("GetUserById")]
        public User GetUserById(int id)
        {
            return _service.GetUserById(id);
            
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
        public User DeleteUserByID(int id)
        {
            return _service.DeleteUserByID(id);
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

        //[HttpGet]
        //[ActionName("GetUser")]
        //public string GetUser(User user)
        //{
        //    //string query = $"select * from \"Users\";";
        //    return _service.GetUser(user);
        //}

        [HttpDelete("DeleteUserById/{id}")]
        public string DeleteUserById(int id)
        {
            return _service.DeleteUserById(id)
                ? "User deleted successfully."
                : "Failed to delete user.";
        }

        [HttpDelete]
        [ActionName("DeleteAllUsers")]
        public string DeleteAllusers()
        {
            return _service.DeleteAllusers();
        }
    }
}
