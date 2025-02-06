using Event_Managment_System.Models;
using Repository;
namespace Services
{
    public class UserService : IUserService
    {
        //controllers->service(business logic)->repositories->Database(static data)
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

        public void DeleteAllUsers()
        {
            _repository.DeleteAllUsers();
        }

        public void DeleteUserByID(int id)
        {
            _repository.DeleteUserByID(id);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public List<User> GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

    }
}
