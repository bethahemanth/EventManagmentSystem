using Event_Managment_System.Models;
using Microsoft.AspNetCore.Mvc;
namespace Services
{
    public class UserService: IUserService
    {
        public string DeleteUserById()
        {
            return "DeteUserById successfully executed";
        }
    }
}
