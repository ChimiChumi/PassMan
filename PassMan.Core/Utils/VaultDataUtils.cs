﻿using Microsoft.Data.Sqlite;
using System.Data;

namespace PassMan.Core
{
    public class VaultDataUtils
    {
        public DataTable GetSecrets(int userId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var connection = new SqliteConnection(ConfigurationManager.DbPath))
                {
                    connection.Open();

                    // Include UserId in the SELECT query
                    using (var command = new SqliteCommand("SELECT vaultId, UserId, UserName, WebSite, PassWord FROM vault WHERE userId = @userId", connection))
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
                // Consider handling the exception more robustly
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }
    }
}
