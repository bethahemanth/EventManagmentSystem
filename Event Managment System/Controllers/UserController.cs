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

        ////[HttpPost]
        ////[ActionName("AddUsers")]
        ////public User AddUser([FromBody] User newuser)
        ////{
        ////    _service.AddUser(newuser);
        ////    return newuser;
        ////}

        //[HttpGet]
        //[ActionName("GetUsers")]
        //public List<User> GetUsers()
        //{
        //    return _service.GetAllUsers();
        //}

        //[HttpGet]
        //[ActionName("GetUserById")]
        //public User GetUserById(int id)
        //{
        //    return _service.GetUserById(id);
            
        //}

        ////[HttpGet]
        ////[ActionName("GetUserById")]
        ////public List<User> GetUserById(int id)
        ////{
        ////    return _service.GetUserById(id);
        ////}

        //[HttpDelete]
        //[ActionName("Deleteusers")]
        //public List<User> DeleteUsers()
        //{
        //    _service.DeleteAllUsers();
        //    return _service.GetAllUsers();
        //}

        //[HttpDelete]
        //[ActionName("DeleteUserById")]
        //public User DeleteUserByID(int id)
        //{
        //    return _service.DeleteUserByID(id);
        //}

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
        public string GetAllUsers()
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
    }
}
