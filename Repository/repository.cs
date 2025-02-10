using Event_Managment_System.Models;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;

namespace Repository
{
    public class repository : IRepository
    {
        private readonly IDatabaseContext _databaseContext;
        public repository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public User? GetUserById(int id)
        {
            return data.users.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteAllUsers()
        {
            data.users.Clear();
        }

        public User DeleteUserByID(int id)
        {
            User user = data.users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                data.users.Remove(user);
            }
            return user;
        }

        public List<User> GetAllUsers()
        {
            return data.users;
        }

        public string CreateTable()
        {
            string tablename = "Users";

            List<string> columns = new List<string>
            {
                "\"Id\" SERIAL PRIMARY KEY",
                "\"Name\" VARCHAR(100)",
                "\"Email\" VARCHAR(255) UNIQUE",
                "\"PasswordHash\" TEXT",
                "\"Role\" VARCHAR(50)"
            };

            string query = $"CREATE TABLE \"{tablename}\" ({string.Join(", ", columns)});";

            return _databaseContext.ExecuteQuery(query);
        }

        public string InsertUser(User user)
        {
            string query = $@"
        INSERT INTO ""Users"" (""Name"", ""Email"", ""PasswordHash"", ""Role"") 
        VALUES ('{user.Name}', '{user.Email}', '{user.PasswordHash}', '{user.Role}')
        RETURNING ""Id"";"; // Returns the new ID

            return _databaseContext.ExecuteQuery(query);
        }

        //public string GetUser(User user)
        //{
        //    string query = $"select * from \"Users\";";
        //    return _databaseContext.ExecuteQuery(query);
        //}

        public string DeleteUserById(int id)
        {
            string query = $"delete from table \"Users\" where Id='{id}'";
            return _databaseContext.ExecuteQuery(query);
        }

        public string DeleteAllusers()
        {
            string query = $"delete from  \"Users\" ";
            return _databaseContext.ExecuteQuery(query);
        }




    }
}

