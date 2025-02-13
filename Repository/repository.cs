using Event_Managment_System.Models;
//using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using DataBase;
using Newtonsoft.Json;
using System.Data;
using System.Collections;

namespace Repository
{
    public class repository : IRepository
    {
        private readonly IDatabaseContext _databaseContext;
        public repository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<User> _users;

        public string CreateTable()
        {
            string tablename = "Users_1504";

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
        INSERT INTO ""Users_1504"" (""Name"", ""Email"", ""PasswordHash"", ""Role"") 
        VALUES ('{user.Name}', '{user.Email}', '{user.PasswordHash}', '{user.Role}')
        RETURNING ""Id"";"; 

            return _databaseContext.ExecuteQuery(query);
        }

        public List<User> GetAllUsers()
        {
            string query = "SELECT * FROM \"Users_1504\"";
            
            return _databaseContext.GetTableData<User>(query);
        }

        public string GetUserById(int id)
        {
            string query = $"SELECT * FROM \"Users_1504\" WHERE \"Id\" = {id}";
            var users = _databaseContext.GetTableData<User>(query);
            return JsonConvert.SerializeObject(users, Formatting.Indented);
        }

     
        public string UpdateUserById(int id, string name, string email, string passwordHash, string role)
        {
            string query = $"UPDATE \"Users_1504\" SET \"Name\" = '{name}', \"Email\" = '{email}', \"Role\" = '{role}', \"PasswordHash\" = '{passwordHash}' WHERE \"Id\" = {id}";
            return _databaseContext.ExecuteQuery(query);
        }


        public string DeleteUserById(int id)
        {
            string query = $"DELETE FROM \"Users_1504\" WHERE \"Id\" = {id}";
            return _databaseContext.ExecuteQuery(query);
        }

        public string DeleteAllusers()
        {
            string query = $"delete from  \"Users_1504\" ";
            return _databaseContext.ExecuteQuery(query);
        }

        

    }
}

