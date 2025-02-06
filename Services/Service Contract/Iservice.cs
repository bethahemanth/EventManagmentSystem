using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Event_Managment_System.Models;
namespace Services
{
    public interface IUserService
    {
        void AddUser(User newuser);
        List<User> GetAllUsers();
    }
}
