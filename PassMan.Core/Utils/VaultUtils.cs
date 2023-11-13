using Microsoft.Data.Sqlite;
using PassMan.Models;
using System.Configuration;
using System.Text.RegularExpressions;

namespace PassMan.Core
{
    public class VaultUtils
    {
        private readonly static string DbPath = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public string AddSecret(Vault vault)
        {
            DataTableUtils table = new DataTableUtils();
            table.CreateTable();

            try
            {
                using (var sql_con = new SqliteConnection(DbPath))
                {
                    sql_con.Open();

                    using (var insertSQL = new SqliteCommand("INSERT INTO vault (UserId, UserName, WebSite, PassWord) VALUES (@UserId, @UserName, @WebSite, @PassWord)", sql_con))
                    {
                        insertSQL.Parameters.AddWithValue("@UserId", vault.UserId);
                        insertSQL.Parameters.AddWithValue("@UserName", vault.UserName);
                        insertSQL.Parameters.AddWithValue("@WebSite", vault.WebSite);
                        insertSQL.Parameters.AddWithValue("@PassWord", vault.PassWord);

                        int result = insertSQL.ExecuteNonQuery();
                        if (result > 0)
                        {
                            return "Success";
                        }
                        else
                        {
                            return "Something went wrong. Secret not added!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public string UpdateSecret(int recordId, string columnName, string editedValue)
        {
            try
            {
                if (columnName == "password")
                {
                    // Regex to check for at least one digit, one lowercase and one uppercase character, and at least 6 characters long
                    if (!Regex.IsMatch(editedValue, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}$"))
                    {
                        return "Password must be at least 6 characters long and include uppercase, lowercase characters, and numbers!";
                    }
                }

                using (var connection = new SqliteConnection(DbPath))
                {
                    connection.Open();
                    using (var command = new SqliteCommand($"UPDATE vault SET {columnName} = @editedValue WHERE vaultId = @recordId", connection))
                    {
                        command.Parameters.AddWithValue("@editedValue", editedValue);
                        command.Parameters.AddWithValue("@recordId", recordId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return ""; // Successful update, no error message
                        }
                        else
                        {
                            return "Update failed, no rows affected."; // Error in updating the database
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "An exception occurred: " + ex.Message; // Return the exception message
            }
        }



        public bool DeleteSecret(int recordId)
        {
            try
            {
                using (var connection = new SqliteConnection(DbPath))
                {
                    connection.Open();

                    using (var command = new SqliteCommand("DELETE FROM vault WHERE vaultId = @vaultId", connection))
                    {
                        command.Parameters.AddWithValue("@vaultId", recordId);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
