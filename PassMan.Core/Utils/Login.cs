using Microsoft.Data.Sqlite;

public class Login
{
    private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";

    public string LoginUser(string username, string password)
    {
        try
        {
            using (var sql_con = new SqliteConnection(dbPath))
            {
                sql_con.Open();

                using (var selectSQL = new SqliteCommand("SELECT PassWord FROM users WHERE Email = @Email OR UserName = @UserName", sql_con))
                {
                    selectSQL.Parameters.AddWithValue("@Email", username);
                    selectSQL.Parameters.AddWithValue("@UserName", username);
                    var storedPassword = (string)selectSQL.ExecuteScalar();

                    if (storedPassword != null && VerifyPassword(password, storedPassword))
                    {
                        return "Success";
                    }
                    else
                    {
                        return "Invalid username or password.";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Logging the exception might be a good idea here.
            return "An error occurred during login: " + ex.Message;
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
