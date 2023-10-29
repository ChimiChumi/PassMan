using Microsoft.Data.Sqlite;
using PassMan.Core;

public class LoginUtils
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public int? UserId { get; set; }
    }

    public LoginResult LoginUser(string username, string password)
    {
        try
        {
            using (var sql_con = new SqliteConnection(ConfigurationManager.DbPath))
            {
                sql_con.Open();

                using (var selectSQL = new SqliteCommand("SELECT id, PassWord FROM users WHERE Email = @UserIdentifier OR UserName = @UserIdentifier", sql_con))
                {
                    selectSQL.Parameters.AddWithValue("@UserIdentifier", username);
                    using (var reader = selectSQL.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var userId = reader.GetInt32(0);
                            var storedPassword = reader.GetString(1);

                            if (VerifyPassword(password, storedPassword))
                            {
                                return new LoginResult { IsSuccess = true, UserId = userId };
                            }
                            else
                            {
                                return new LoginResult { IsSuccess = false, ErrorMessage = "Invalid username or password." };
                            }
                        }
                        else
                        {
                            return new LoginResult { IsSuccess = false, ErrorMessage = "Invalid username or password." };
                        }
                    }
                }
            }
        }

        catch (Exception ex)
        {
            return new LoginResult { IsSuccess = false, ErrorMessage = "An error occurred during login: " + ex.Message };
        }
    }

    private bool VerifyPassword(string inputPassword, string storedPassword)
    {
        return inputPassword == storedPassword;
    }
}
