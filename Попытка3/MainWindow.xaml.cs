using System.Windows;
using Попытка3;

namespace Попытка3
{
    public partial class MainWindow : Window
    {
        private (string Username, string Password)[] users = new (string Username, string Password)[]
        {
            ("log1", "pass1"),
            ("log2", "pass2"),
            ("log3", "pass3"),
            ("log4", "pass4"),
            ("log5", "pass5"),
            ("log6", "pass6"),
            ("log7", "pass7"),
            ("log8", "pass8"),
            ("log9", "pass9"),
            ("log0", "pass0")
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле логина или пароля пусто. Пожалуйста, введите логин или пароль.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // Открываем новое окно
                    SuccessWindow successWindow = new SuccessWindow();
                    successWindow.Show();

                    // Закрываем текущее окно
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Неверный логин или пароль.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}