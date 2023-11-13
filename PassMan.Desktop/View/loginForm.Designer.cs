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
            loginBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 27);
            label1.Name = "label1";
            label1.Size = new Size(249, 40);
            label1.TabIndex = 0;
            label1.Text = "Greetings User!";
            label1.Click += label1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(157, 207);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label2_Click;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdLabel.Location = new Point(157, 267);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(98, 25);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(303, 201);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(282, 30);
            usernameTextBox.TabIndex = 3;
            // 
            // pwdTextBox
            // 
            pwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            pwdTextBox.Cursor = Cursors.IBeam;
            pwdTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pwdTextBox.Location = new Point(303, 261);
            pwdTextBox.Margin = new Padding(3, 4, 3, 4);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(282, 30);
            pwdTextBox.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkGray;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.Black;
            loginBtn.FlatAppearance.BorderSize = 2;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.Olive;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.Gold;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ActiveCaptionText;
            loginBtn.Location = new Point(227, 404);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(229, 47);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "🔓 Access Vault 🔓";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += Login_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 143);
            label2.Name = "label2";
            label2.Size = new Size(371, 43);
            label2.TabIndex = 7;
            label2.Text = "Please authenticate yourself:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MV Boli", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(174, 321);
            label3.Name = "label3";
            label3.Size = new Size(269, 33);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account?";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("MV Boli", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(432, 320);
            label4.Name = "label4";
            label4.Size = new Size(96, 33);
            label4.TabIndex = 9;
            label4.Text = "Register Here!";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += Register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(685, 485);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginBtn);
            Controls.Add(pwdTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(pwdLabel);
            Controls.Add(usernameLabel);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button loginBtn;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}