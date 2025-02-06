using Event_Managment_System.Models;
using Database;
//using Repository;
namespace Repository
{
    public class repository : IRepository
    {

        public void AddUser(User user)
        {
            data.users.Add(user);
        }

        public void DeleteAllUsers()
        {
            data.users.Clear();
        }

        public void DeleteUserByID(int id)
        {
            data.users.RemoveAll(x => x.Id == id);
        }
        public List<User> GetAllUsers()
        {
            return data.users;
        }

        //public ListGetUserById
        //
        //private User _user;
        //public void (User user)
        //    {
        //    _user=user;
        //    }
    }
}
