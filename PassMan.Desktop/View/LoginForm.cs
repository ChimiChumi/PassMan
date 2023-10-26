using PassMan.Core;
using PassMan.Models;

namespace PassMan.Desktop.View
{
    public partial class LoginForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public LoginForm()
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

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = pwdTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Input fields cannot be empty!");
                return;
            }

            Login login = new Login();
            string loginResult = login.LoginUser(username, password);

            if (loginResult == "Success")
            {
                MessageBox.Show("Authentication Successful!");
                VaultForm vault = new VaultForm();
                vault.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Authentication Failed! {loginResult}");
            }
        }

    }
}
