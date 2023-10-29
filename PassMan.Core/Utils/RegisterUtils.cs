using Microsoft.Data.Sqlite;
using PassMan.Models;

namespace PassMan.Core
{
    public class RegisterUtils
    {
        public string RegisterUser(User user)
        {
            DataTableUtils table = new DataTableUtils();
            table.CreateTable();

            if (EmailExists(user.Email))
            {
                return "Email already registered!";
            }

            try
            {
                using (var sql_con = new SqliteConnection(ConfigurationManager.DbPath))
                {
                    sql_con.Open();

                    using (var insertSQL = new SqliteCommand("INSERT INTO users (UserName, Email, PassWord) VALUES (@UserName, @Email, @PassWord)", sql_con))
                    {
                        insertSQL.Parameters.AddWithValue("@UserName", user.UserName);
                        insertSQL.Parameters.AddWithValue("@Email", user.Email);
                        insertSQL.Parameters.AddWithValue("@PassWord", user.PassWord);

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

        private bool EmailExists(string email)
        {
            using (var sql_con = new SqliteConnection(ConfigurationManager.DbPath))
            {
                sql_con.Open();

                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM users WHERE Email = @Email", sql_con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
        }
    }

}