namespace PassMan.Desktop.View
{
    partial class RegisterForm
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
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.Click += label1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(165, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(56, 19);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            emailLabel.Click += label2_Click;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdLabel.Location = new Point(127, 200);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(90, 19);
            pwdLabel.TabIndex = 7;
            pwdLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Cursor = Cursors.IBeam;
            emailTextBox.Location = new Point(273, 157);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(247, 23);
            emailTextBox.TabIndex = 2;
            // 
            // pwdTextBox
            // 
            pwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            pwdTextBox.Cursor = Cursors.IBeam;
            pwdTextBox.Location = new Point(273, 198);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(247, 23);
            pwdTextBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.PaleVioletRed;
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderColor = Color.DimGray;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = SystemColors.ControlLightLight;
            cancelBtn.Location = new Point(165, 302);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 31);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += Cancel_Click;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.SteelBlue;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatAppearance.BorderColor = Color.DimGray;
            signupBtn.FlatAppearance.BorderSize = 2;
            signupBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            signupBtn.ForeColor = SystemColors.ControlLightLight;
            signupBtn.Location = new Point(346, 302);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(87, 31);
            signupBtn.TabIndex = 10;
            signupBtn.Text = "Sign Up";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += Signup_Click;
            // 
            // repeatPwdTextBox
            // 
            repeatPwdTextBox.BorderStyle = BorderStyle.FixedSingle;
            repeatPwdTextBox.Cursor = Cursors.IBeam;
            repeatPwdTextBox.Location = new Point(273, 241);
            repeatPwdTextBox.Name = "repeatPwdTextBox";
            repeatPwdTextBox.PasswordChar = '*';
            repeatPwdTextBox.Size = new Size(247, 23);
            repeatPwdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 236);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 8;
            label2.Text = "Repeat";
            label2.Click += label2_Click_1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FlatStyle = FlatStyle.Popup;
            usernameLabel.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(131, 121);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(90, 19);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label3_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Location = new Point(273, 118);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(247, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 253);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(127, 72);
            label4.Name = "label4";
            label4.Size = new Size(360, 26);
            label4.TabIndex = 12;
            label4.Text = "Let's create your personal vault:";
            label4.Click += label4_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(599, 364);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Name = "RegisterForm";
            Text = "Sign Up";
            FormClosing += SignupForm_FormClosing;
            Load += RegisterForm_Load;
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
        private Label label3;
        private Label label4;
    }
}