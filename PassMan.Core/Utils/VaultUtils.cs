using Microsoft.Data.Sqlite;
using PassMan.Models;

namespace PassMan.Core
{
    public class VaultUtils
    {
        private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";
        public string AddSecret(Vault vault)
        {
            DataTableUtils table = new DataTableUtils();
            table.CreateTable();

            try
            {
                using (var sql_con = new SqliteConnection(dbPath))
                {
                    sql_con.Open();

                    using (var insertSQL = new SqliteCommand("INSERT INTO vault (UserName, WebSite, PassWord) VALUES (@UserName, @WebSite, @PassWord)", sql_con))
                    {
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
                            return "User registration failed!";
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