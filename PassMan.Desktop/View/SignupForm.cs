using PassMan.Core;
using PassMan.Models;

namespace PassMan.Desktop.View
{
    public partial class SignupForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public SignupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            pwdTextBox.Text = string.Empty;
            repeatPwdTextBox.Text = string.Empty;
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = pwdTextBox.Text;
            string pwdRepeat = repeatPwdTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Input fields cannot be empty!");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }

            if (password != pwdRepeat)
            {
                MessageBox.Show("Entered passwords do not match!");
                return;
            }

            User user = new User(username, email, password);
            RegisterUtils register = new RegisterUtils();
            string registrationResult = register.RegisterUser(user);

            if (registrationResult == "Success")
            {
                MessageBox.Show($"User registered with username: {username}");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(registrationResult);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
