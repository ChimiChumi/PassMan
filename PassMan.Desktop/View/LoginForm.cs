namespace PassMan.Desktop.View
{
    public partial class LoginForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

            LoginUtils login = new LoginUtils();
            var loginResult = login.LoginUser(username, password);

            if (loginResult.IsSuccess)
            {
                if (loginResult.UserId.HasValue)
                {
                    VaultForm vault = new VaultForm(this, loginResult.UserId.Value);
                    this.Hide();
                    vault.Show();
                }
                else
                {
                    MessageBox.Show("User ID is missing. Cannot proceed.");
                }
            }
            else
            {
                MessageBox.Show($"Authentication Failed! {loginResult.ErrorMessage}");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm signupForm = new RegisterForm(this);
            this.Hide();
            signupForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
