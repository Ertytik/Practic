using System;
using System.Windows.Forms;

namespace Сельскохозяйственные_работы
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при загрузке формы
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim(); // Удаляем пробелы
            string password = txtPassword.Text.Trim(); // Удаляем пробелы

            const string validUsername = "ad";
            const string validPassword = "123"; // В реальных приложениях используйте хэширование паролей

            try
            {
                if (username == validUsername && password == validPassword)
                {
                    MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK);
                    MainForm mainForm = new MainForm();
                    mainForm.Show(); // Открыть главную форму
                    this.Hide(); // Скрыть форму авторизации
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
