using Microsoft.Data.Sqlite;

namespace PassMan.Core
{
    public class DataTableUtils
    {
        private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";
        public void CreateTable()
        {
            using (var connection = new SqliteConnection(dbPath))
            {
                connection.Open();

                var command = connection.CreateCommand();

                // Create users table
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL,
                    email TEXT NOT NULL UNIQUE, 
                    password TEXT NOT NULL);";
                command.ExecuteNonQuery();


                // Create vault table with foreign key reference to users
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS vault (
                    vaultId INTEGER PRIMARY KEY AUTOINCREMENT, 
                    userId TEXT NOT NULL, 
                    username TEXT NOT NULL, 
                    website TEXT NOT NULL,
                    password TEXT NOT NULL,
                    FOREIGN KEY (userId) REFERENCES users(id));";
                command.ExecuteNonQuery();
            }
        }
    }
}