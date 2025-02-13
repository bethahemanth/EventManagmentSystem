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
        string CreateTable();
        public string InsertUser(User user);

        public List<User> GetAllUsers();

        public string GetUserById(int id);

        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role);
        public string DeleteUserById(int id);

        public string DeleteAllusers();

        //public List<User> _GetAllUsers();

    }
}
