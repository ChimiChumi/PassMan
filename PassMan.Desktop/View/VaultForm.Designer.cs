namespace PassMan.Desktop.View
{
    partial class VaultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            secretTable = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addNewSecretToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)secretTable).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // secretTable
            // 
            secretTable.AllowUserToAddRows = false;
            secretTable.AllowUserToDeleteRows = false;
            secretTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secretTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            secretTable.BackgroundColor = Color.LightSteelBlue;
            secretTable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            secretTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            secretTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "*empty*";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            secretTable.DefaultCellStyle = dataGridViewCellStyle2;
            secretTable.Location = new Point(12, 34);
            secretTable.Name = "secretTable";
            secretTable.ReadOnly = true;
            secretTable.RowTemplate.Height = 25;
            secretTable.Size = new Size(531, 404);
            secretTable.TabIndex = 0;
            secretTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(555, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewSecretToolStripMenuItem, logOutToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("MV Boli", 13F, FontStyle.Bold, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Margin = new Padding(15, 0, 0, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(72, 27);
            fileToolStripMenuItem.Text = "Menu";
            // 
            // addNewSecretToolStripMenuItem
            // 
            addNewSecretToolStripMenuItem.BackColor = Color.Silver;
            addNewSecretToolStripMenuItem.Name = "addNewSecretToolStripMenuItem";
            addNewSecretToolStripMenuItem.Size = new Size(235, 28);
            addNewSecretToolStripMenuItem.Text = "Add New Secret";
            addNewSecretToolStripMenuItem.Click += AddNewSecret_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.Silver;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(235, 28);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += LogOut_Click;
            // 
            // VaultForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gray;
            ClientSize = new Size(555, 450);
            Controls.Add(secretTable);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VaultForm";
            Text = "VaultForm";
            FormClosing += VaultForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)secretTable).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView secretTable;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addNewSecretToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}