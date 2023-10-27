namespace PassMan.Desktop.View
{
    public partial class VaultForm : Form
    {
        public VaultForm()
        {
            InitializeComponent();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewSecret_Click(object sender, EventArgs e)
        {
            AddSecretForm addSecretForm = new AddSecretForm();
            addSecretForm.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
