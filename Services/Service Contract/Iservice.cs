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
        List<User> GetAllUsers();
        void DeleteAllUsers();
        User DeleteUserByID(int id);
        User GetUserById(int id);
        string CreateTable();
        public string InsertUser(User user);

        //public string GetUser(User user);
        public string DeleteUserById(id);

        public string DeleteAllusers();
    }
}
