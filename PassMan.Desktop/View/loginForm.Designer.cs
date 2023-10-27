namespace PassMan.Desktop.View
{
    partial class LoginForm
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
            usernameLabel = new Label();
            pwdLabel = new Label();
            usernameTextBox = new TextBox();
            pwdTextBox = new TextBox();
            cancelBtn = new Button();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 54);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.Click += label1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(223, 117);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label2_Click;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new Point(223, 159);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(57, 15);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(333, 114);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(247, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // pwdTextBox
            // 
            pwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            pwdTextBox.Location = new Point(333, 159);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(247, 23);
            pwdTextBox.TabIndex = 4;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(276, 233);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 31);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += Cancel_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(437, 233);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(87, 31);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Log In";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(cancelBtn);
            Controls.Add(pwdTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(pwdLabel);
            Controls.Add(usernameLabel);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Authentication";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label usernameLabel;
        private Label pwdLabel;
        private TextBox usernameTextBox;
        private TextBox pwdTextBox;
        private Button cancelBtn;
        private Button loginBtn;
    }
}