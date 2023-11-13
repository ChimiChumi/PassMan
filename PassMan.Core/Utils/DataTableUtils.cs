using System;
using System.Configuration;
using System.IO;
using Microsoft.Data.Sqlite;

namespace PassMan.Core
{
    public class DataTableUtils
    {
        private readonly static string DbPath = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public void CreateTable()
        {
            using (var connection = new SqliteConnection(DbPath))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL,
                email TEXT NOT NULL UNIQUE, 
                password TEXT NOT NULL);";
                command.ExecuteNonQuery();

                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS vault (
                vaultId INTEGER PRIMARY KEY AUTOINCREMENT, 
                userId INTEGER NOT NULL, 
                username TEXT NOT NULL, 
                website TEXT NOT NULL,
                password TEXT NOT NULL,
                FOREIGN KEY (userId) REFERENCES users(id));";
                command.ExecuteNonQuery();
            }
        }
    }
}
