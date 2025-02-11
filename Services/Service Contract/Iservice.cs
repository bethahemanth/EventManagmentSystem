using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Database;
using Event_Managment_System.Models;
namespace Services
{
    public interface IUserService
    {
        //List<User> GetAllUsers();
        //void DeleteAllUsers();
        //User DeleteUserByID(int id);
        //User GetUserById(int id);
        string CreateTable();
        public string InsertUser(User user);

        public string GetAllUsers();
        public string GetUserById(int id);

        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role);
        public string DeleteUserById(int id);

        public string DeleteAllusers();
    }
}
