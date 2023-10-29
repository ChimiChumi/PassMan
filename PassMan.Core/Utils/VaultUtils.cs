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
    }
}