using System.ComponentModel;
using Event_Managment_System.Models;
using Repository;
using static Services.UserService;
namespace Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }


        public string CreateTable()
        {
            return _repository.CreateTable();
        }

        public string InsertUser(User user)
        {
            return _repository.InsertUser(user);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public string GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

        public string UpdateUserById(int id, string name, string email, string PasswordHash, string Role)
        {
            return _repository.UpdateUserById(id, name, email, PasswordHash, Role);
        }

        public string DeleteUserById(int id)
        {
            return _repository.DeleteUserById(id);
        }

        public string DeleteAllusers()
        {
            string query = $"delete from table \"Users\" ";
            return _repository.DeleteAllusers();
        }

           public class groupbyrole
        {
            public string Role { get; set; }
            public List<User> users { get; set; }
        }

        public class CountEmployees
        {
            public string Role { get; set; }
            public int count { get; set; }
        }

        //Group users by their role
        public List<groupbyrole> GroupByRole()
        {
            List<groupbyrole> g = _repository.GetAllUsers()
            .GroupBy(u => u.Role)
            .Select(g => new groupbyrole 
        {
            Role = g.Key,
            users = g.ToList()
        })
        .ToList();
            return g;
        }

        //Count how many users in each role
        public List<CountEmployees> _CountEmployees()
        {
            List<CountEmployees> c = _repository.GetAllUsers().GroupBy(u => u.Role)
                .Select(g => new CountEmployees
                {
                    Role = g.Key,
                    count = g.Count()
                }).ToList();
            return c;
        }

        //Get All users within the specific role
        public List<User> _getUsers(string role)
        {
            List<User> u = _repository.GetAllUsers().Where(x => x.Role == role).ToList();
            return u;
        }


    }
}
