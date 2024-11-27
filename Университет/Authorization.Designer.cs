namespace Сельскохозяйственные_работы
{
    partial class Authorization
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            Username = new Label();
            Password = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(372, 412);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DimGray;
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(324, 212);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 26);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DimGray;
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(324, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 26);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.FlatStyle = FlatStyle.Popup;
            Username.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Transparent;
            Username.Location = new Point(324, 187);
            Username.Name = "Username";
            Username.Size = new Size(65, 22);
            Username.TabIndex = 7;
            Username.Text = "Логин";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.FlatStyle = FlatStyle.Popup;
            Password.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.Transparent;
            Password.Location = new Point(324, 278);
            Password.Name = "Password";
            Password.Size = new Size(75, 22);
            Password.TabIndex = 8;
            Password.Text = "Пароль";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(884, 561);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "Authorization";
            Text = "Authorization";
            Load += Authorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label Username;
        private Label Password;
    }
}