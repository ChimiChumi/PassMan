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
            label4 = new Label();
            vaultCancelButton = new Button();
            vaultAddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 110);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // secretSiteTextBox
            // 
            secretSiteTextBox.Location = new Point(127, 39);
            secretSiteTextBox.Name = "secretSiteTextBox";
            secretSiteTextBox.PlaceholderText = "ex: youtube.com, ...";
            secretSiteTextBox.Size = new Size(146, 23);
            secretSiteTextBox.TabIndex = 3;
            // 
            // secretUsernameTextBox
            // 
            secretUsernameTextBox.Location = new Point(127, 71);
            secretUsernameTextBox.Name = "secretUsernameTextBox";
            secretUsernameTextBox.PlaceholderText = "ex: Charlie123, ...";
            secretUsernameTextBox.Size = new Size(146, 23);
            secretUsernameTextBox.TabIndex = 4;
            // 
            // secretPwdTextBox
            // 
            secretPwdTextBox.Location = new Point(127, 107);
            secretPwdTextBox.Name = "secretPwdTextBox";
            secretPwdTextBox.PasswordChar = '*';
            secretPwdTextBox.Size = new Size(146, 23);
            secretPwdTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 9);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 6;
            label4.Text = "Secret to be saved:";
            // 
            // vaultCancelButton
            // 
            vaultCancelButton.Location = new Point(69, 147);
            vaultCancelButton.Name = "vaultCancelButton";
            vaultCancelButton.Size = new Size(75, 23);
            vaultCancelButton.TabIndex = 7;
            vaultCancelButton.Text = "Cancel";
            vaultCancelButton.UseVisualStyleBackColor = true;
            vaultCancelButton.Click += addCancel_Click;
            // 
            // vaultAddButton
            // 
            vaultAddButton.Location = new Point(168, 147);
            vaultAddButton.Name = "vaultAddButton";
            vaultAddButton.Size = new Size(75, 23);
            vaultAddButton.TabIndex = 8;
            vaultAddButton.Text = "Add";
            vaultAddButton.UseVisualStyleBackColor = true;
            vaultAddButton.Click += addEntry_Click;
            // 
            // AddSecretForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 182);
            Controls.Add(vaultAddButton);
            Controls.Add(vaultCancelButton);
            Controls.Add(label4);
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
        private Label label4;
        private Button vaultCancelButton;
        private Button vaultAddButton;
    }
}