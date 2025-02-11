using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event_Managment_System.Models;

namespace Repository
{
     public interface IRepository
    {
        //List<User> GetAllUsers();
        //User GetUserById(int id);
        //void DeleteAllUsers();
        //User DeleteUserByID(int id);

        string CreateTable();
        public string InsertUser(User user);

        public string GetAllUsers();

        public string GetUserById(int id);

        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role);
        public string DeleteUserById(int id);

        public string DeleteAllusers();
        

    }
}
