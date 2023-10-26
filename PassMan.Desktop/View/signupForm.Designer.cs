namespace PassMan.Desktop.View
{
    partial class SignupForm
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
            emailLabel = new Label();
            pwdLabel = new Label();
            emailTextBox = new TextBox();
            pwdTextBox = new TextBox();
            cancelBtn = new Button();
            signupBtn = new Button();
            repeatPwdTextBox = new TextBox();
            label2 = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.Click += label1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(265, 138);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            emailLabel.Click += label2_Click;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new Point(244, 183);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(57, 15);
            pwdLabel.TabIndex = 7;
            pwdLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(333, 136);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(247, 23);
            emailTextBox.TabIndex = 2;
            // 
            // pwdTextBox
            // 
            pwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            pwdTextBox.Location = new Point(333, 181);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(247, 23);
            pwdTextBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(293, 308);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 31);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += Cancel_Click;
            // 
            // signupBtn
            // 
            signupBtn.Location = new Point(445, 308);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(87, 31);
            signupBtn.TabIndex = 10;
            signupBtn.Text = "Sign Up";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += Signup_Click;
            // 
            // repeatPwdTextBox
            // 
            repeatPwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            repeatPwdTextBox.Location = new Point(333, 226);
            repeatPwdTextBox.Name = "repeatPwdTextBox";
            repeatPwdTextBox.PasswordChar = '*';
            repeatPwdTextBox.Size = new Size(247, 23);
            repeatPwdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 228);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "Repeat Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(244, 94);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label3_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(333, 92);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(247, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // signupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(label2);
            Controls.Add(repeatPwdTextBox);
            Controls.Add(signupBtn);
            Controls.Add(cancelBtn);
            Controls.Add(pwdTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(pwdLabel);
            Controls.Add(emailLabel);
            Controls.Add(label1);
            Name = "signupForm";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label emailLabel;
        private Label pwdLabel;
        private TextBox emailTextBox;
        private TextBox pwdTextBox;
        private Button cancelBtn;
        private Button signupBtn;
        private TextBox repeatPwdTextBox;
        private Label label2;
        private Label usernameLabel;
        private TextBox usernameTextBox;
    }
}