using PassMan.Core;
using System.Data;

namespace PassMan.Desktop.View
{
    public partial class VaultForm : Form
    {
        private readonly LoginForm _loginForm;
        private readonly int _userId;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public VaultForm(LoginForm loginForm, int userId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.VaultForm_Load);
            _loginForm = loginForm;
            _userId = userId;

            secretTable.Columns.Add("RowNum", "No.");
        }

        private void VaultForm_Load(object sender, EventArgs e)
        {
            LoadSecrets();
        }

        private void LoadSecrets()
        {
            VaultDataUtils vaultDataUtils = new VaultDataUtils();
            DataTable userSecrets = vaultDataUtils.GetSecrets(_userId);
            secretTable.DataSource = userSecrets;

            secretTable.Columns["Username"].HeaderText = "User Name";
            secretTable.Columns["Website"].HeaderText = "Website";
            secretTable.Columns["Password"].HeaderText = "Pass Code";

            for (int i = 0; i < secretTable.Rows.Count; i++)
            {
                secretTable.Rows[i].Cells["RowNum"].Value = (i + 1).ToString();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewSecret_Click(object sender, EventArgs e)
        {
            AddSecretForm addSecretForm = new AddSecretForm(_userId);
            var result = addSecretForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadSecrets(); // Reload the secrets if a new one was added
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void VaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
