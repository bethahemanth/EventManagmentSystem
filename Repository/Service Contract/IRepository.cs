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
        //List<user>
        void AddUser(User user);
        List<User> GetAllUsers();
        void GetUserById(int id);
        void DeleteAllUsers();
        void DeleteUserByID(int id);
        
    }
}
