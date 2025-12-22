using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarParkC_.Classes
{
    internal class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "carpark.db");

            _connectionString = $"Data Source={dbPath}";
        }
        public bool CheckUser(string username, string password)
        {
            var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText =
            @"
                SELECT COUNT(1)
                From STAFF
                WHERE name = $name AND pass = $pass
            ";

            cmd.Parameters.AddWithValue("$name", username);
            cmd.Parameters.AddWithValue("$pass", password);

            var result = cmd.ExecuteScalar();
            return Convert.ToInt32(result) == 1;
        }
    }
}
