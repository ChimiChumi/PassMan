using Microsoft.Data.Sqlite;

public class LoginUtils
{
    private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

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
            using (var sql_con = new SqliteConnection(dbPath))
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
                                /*AllocConsole();
                                Console.WriteLine("User ID: " + userId);*/
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
        // Here, you should implement password hashing and compare the hashed input password with the stored hashed password.
        // NEVER store passwords in plain text in the database.
        // For simplicity, this example assumes passwords are stored in plain text.
        // In a real-world application, use a secure hashing algorithm like bcrypt or Argon2.

        return inputPassword == storedPassword;
    }
}
