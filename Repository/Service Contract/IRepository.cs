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
        List<User> GetAllUsers();
        User GetUserById(int id);
        void DeleteAllUsers();
        User DeleteUserByID(int id);

        string CreateTable();
        public string InsertUser(User user);

        //public string GetUser(User user);
        public string DeleteUserById(int id);

        public string DeleteAllusers();
        

    }
}
