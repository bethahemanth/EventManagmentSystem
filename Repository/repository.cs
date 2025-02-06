using Event_Managment_System.Models;
using Database;
namespace Repository
{
    public class repository : IRepository
    {
       
        void IRepository.AddUser(User user)
        {
            data.users.Add(user);
        }
        public List<User> GetAllUsers()
        {
            return data.users;
        }
    }
}
