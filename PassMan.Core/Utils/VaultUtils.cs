using Microsoft.Data.Sqlite;
using PassMan.Models;

namespace PassMan.Core
{
    public class VaultUtils
    {
        public string AddSecret(Vault vault)
        {
            DataTableUtils table = new DataTableUtils();
            table.CreateTable();

            try
            {
                using (var sql_con = new SqliteConnection(ConfigurationManager.DbPath))
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

        public bool UpdateSecret(int recordId, string columnName, string editedValue)
        {
            try
            {
                using (var connection = new SqliteConnection(ConfigurationManager.DbPath))
                {
                    connection.Open();

                    // Use parameterized queries to prevent SQL injection
                    using (var command = new SqliteCommand($"UPDATE vault SET {columnName} = @editedValue WHERE vaultId = @recordId", connection))
                    {
                        command.Parameters.AddWithValue("@editedValue", editedValue);
                        command.Parameters.AddWithValue("@recordId", recordId);

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


        public bool DeleteSecret(int recordId)
        {
            try
            {
                using (var connection = new SqliteConnection(ConfigurationManager.DbPath))
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
