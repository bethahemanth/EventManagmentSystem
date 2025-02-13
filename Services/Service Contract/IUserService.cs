using Event_Managment_System.Models;
using static Services.UserService;
namespace Services
{
    public interface IUserService
    {
        string CreateTable();
        public string InsertUser(User user);
        public List<User> GetAllUsers();
        public string GetUserById(int id);

        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role);
        public string DeleteUserById(int id);

        public string DeleteAllusers();

        public List<groupbyrole> GroupByRole();

        public List<CountEmployees> _CountEmployees();

        public List<User> _getUsers(string role);
    }
}
