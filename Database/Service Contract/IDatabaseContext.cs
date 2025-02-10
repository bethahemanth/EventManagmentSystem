﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataBase
{
    public interface IDatabaseContext
    {
        NpgsqlConnection CreateConnection();

        string ExecuteQuery(string query);
    }
}
