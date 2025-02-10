﻿using Event_Managment_System.Models;
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

        public void DeleteAllUsers()
        {
            _repository.DeleteAllUsers();
        }

        public User DeleteUserByID(int id)
        {
            //_repository.DeleteUserByID(id);
            return _repository.DeleteUserByID(id);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

        public string CreateTable()
        {
            return _repository.CreateTable();
        }

        public string InsertUser(User user)
        {
            return _repository.InsertUser(user);
        }

        //public string GetUser(User user)
        //{
        //    //string query = $"select * from \"Users\";";
        //    return _repository.GetUser(user);
        //}

        public string DeleteUserById(int id)
        {
            return _repository.DeleteUserById(id);
        }

        public string DeleteAllusers()
        {
            string query = $"delete from table \"Users\" ";
            return _repository.DeleteAllusers();
        }

    }
}
