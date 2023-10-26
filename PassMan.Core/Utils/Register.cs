﻿using Microsoft.Data.Sqlite;
using PassMan.Models;

namespace PassMan.Core
{
    public class Register
    {
        private readonly string dbPath = "Data Source=D:\\University\\PassMan\\resources\\data.db";

        public string RegisterUser(User user)
        {
            DataTable table = new DataTable();
            table.CreateTable();

            if (EmailExists(user.Email))
            {
                return "Email already registered!";
            }

            try
            {
                using (var sql_con = new SqliteConnection(dbPath))
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
            using (var sql_con = new SqliteConnection(dbPath))
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