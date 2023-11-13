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

            secretTable.Columns["vaultId"].Visible = false;
            secretTable.Columns["UserId"].Visible = false;

            secretTable.Columns["UserName"].HeaderText = "User Name";
            secretTable.Columns["WebSite"].HeaderText = "Website";
            secretTable.Columns["PassWord"].HeaderText = "Pass Code";
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secretTable.SelectedCells.Count > 0)
            {
                int rowIndex = secretTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = secretTable.Rows[rowIndex];

                secretTable.BeginEdit(true);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secretTable.SelectedCells.Count > 0)
            {
                int rowIndex = secretTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = secretTable.Rows[rowIndex];

                int recordIdToDelete = Convert.ToInt32(selectedRow.Cells["vaultId"].Value);

                VaultUtils utils = new VaultUtils();
                if (utils.DeleteSecret(recordIdToDelete))
                {
                    secretTable.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Failed to delete the record.");
                }
            }
        }

        private void secretTable_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = secretTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string columnName = secretTable.Columns[e.ColumnIndex].Name;
                string editedValue = editedCell.Value?.ToString();

                int recordId = Convert.ToInt32(secretTable.Rows[e.RowIndex].Cells["vaultId"].Value);

                VaultUtils utils = new VaultUtils();
                string updateResult = utils.UpdateSecret(recordId, columnName, editedValue);

                if (!string.IsNullOrEmpty(updateResult))
                {
                    MessageBox.Show(updateResult, "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadSecrets();
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
