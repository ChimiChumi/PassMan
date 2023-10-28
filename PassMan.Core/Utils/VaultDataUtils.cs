using Microsoft.Data.Sqlite;
using System.Data;

namespace PassMan.Core
{
    public class VaultDataUtils
    {
        private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";
        
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public DataTable GetSecrets(int userId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var connection = new SqliteConnection("Data Source=D:\\University\\PassMan\\resources\\data.db"))
                {
                    connection.Open();

                    using (var command = new SqliteCommand("SELECT UserName, WebSite, PassWord FROM vault WHERE userId = @userId", connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }
    }
}
