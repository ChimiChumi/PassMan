using PassMan.Models;
using PassMan.Core;

namespace PassMan.Desktop.View
{
    public partial class AddSecretForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private readonly int _userId;

        public AddSecretForm(int userId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _userId = userId;
        }

        private void AddSecretForm_Load(object sender, EventArgs e)
        {

        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            string username = secretUsernameTextBox.Text.Trim();
            string website = secretSiteTextBox.Text.Trim();
            string password = secretPwdTextBox.Text.Trim();

            if (string.IsNullOrEmpty(website) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Input fields cannot be empty!");
                return;
            }

            Vault vault = new Vault(_userId, username, website, password);
            VaultUtils vaultUtils = new VaultUtils();
            string result = vaultUtils.AddSecret(vault);

            if (result == "Success")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
