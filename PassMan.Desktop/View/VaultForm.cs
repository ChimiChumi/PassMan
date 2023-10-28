namespace PassMan.Desktop.View
{
    public partial class VaultForm : Form
    {
        private LoginForm loginForm;
        private readonly int _userId;

        public VaultForm(LoginForm loginForm, int userId)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            _userId = userId;
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewSecret_Click(object sender, EventArgs e)
        {
            AddSecretForm addSecretForm = new AddSecretForm(_userId);
            addSecretForm.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm.Show();
        }

        private void VaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
