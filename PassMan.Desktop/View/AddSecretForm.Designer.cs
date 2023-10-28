namespace PassMan.Desktop.View
{
    partial class AddSecretForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            secretSiteTextBox = new TextBox();
            secretUsernameTextBox = new TextBox();
            secretPwdTextBox = new TextBox();
            vaultCancelButton = new Button();
            vaultAddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 97);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // secretSiteTextBox
            // 
            secretSiteTextBox.BackColor = SystemColors.Window;
            secretSiteTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            secretSiteTextBox.Location = new Point(133, 22);
            secretSiteTextBox.Name = "secretSiteTextBox";
            secretSiteTextBox.Size = new Size(165, 25);
            secretSiteTextBox.TabIndex = 3;
            // 
            // secretUsernameTextBox
            // 
            secretUsernameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            secretUsernameTextBox.Location = new Point(133, 58);
            secretUsernameTextBox.Name = "secretUsernameTextBox";
            secretUsernameTextBox.Size = new Size(165, 25);
            secretUsernameTextBox.TabIndex = 4;
            // 
            // secretPwdTextBox
            // 
            secretPwdTextBox.BackColor = SystemColors.Window;
            secretPwdTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            secretPwdTextBox.Location = new Point(133, 94);
            secretPwdTextBox.Name = "secretPwdTextBox";
            secretPwdTextBox.PasswordChar = '*';
            secretPwdTextBox.Size = new Size(165, 25);
            secretPwdTextBox.TabIndex = 5;
            // 
            // vaultCancelButton
            // 
            vaultCancelButton.BackColor = Color.RosyBrown;
            vaultCancelButton.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            vaultCancelButton.Location = new Point(69, 141);
            vaultCancelButton.Name = "vaultCancelButton";
            vaultCancelButton.Size = new Size(76, 34);
            vaultCancelButton.TabIndex = 7;
            vaultCancelButton.Text = "Cancel";
            vaultCancelButton.UseVisualStyleBackColor = false;
            vaultCancelButton.Click += addCancel_Click;
            // 
            // vaultAddButton
            // 
            vaultAddButton.BackColor = Color.DarkSeaGreen;
            vaultAddButton.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            vaultAddButton.Location = new Point(181, 141);
            vaultAddButton.Name = "vaultAddButton";
            vaultAddButton.Size = new Size(80, 34);
            vaultAddButton.TabIndex = 8;
            vaultAddButton.Text = "Add";
            vaultAddButton.UseVisualStyleBackColor = false;
            vaultAddButton.Click += addEntry_Click;
            // 
            // AddSecretForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(323, 182);
            Controls.Add(vaultAddButton);
            Controls.Add(vaultCancelButton);
            Controls.Add(secretPwdTextBox);
            Controls.Add(secretUsernameTextBox);
            Controls.Add(secretSiteTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddSecretForm";
            Text = "Save New Secret";
            Load += AddSecretForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox secretSiteTextBox;
        private TextBox secretUsernameTextBox;
        private TextBox secretPwdTextBox;
        private Button vaultCancelButton;
        private Button vaultAddButton;
    }
}