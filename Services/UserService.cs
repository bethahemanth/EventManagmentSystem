using Event_Managment_System.Models;
using Repository;
namespace Services
{
    public class UserService : IUserService
    {
        //public string DeleteUserById()
        //{
        //    return "DeteUserById successfully executed";
        //}
        private readonly IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }
        public void AddUser(User newuser)
        {
            _repository.AddUser(newuser);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }
    }
}
