using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            DemoEntities db = new DemoEntities();

            string login = Login.Text;
            string password = Password.Text;

            try
            {
                User user = db.Users.Where((u) => u.user_login == login && u.user_password == password).Single();

                if (user.user_role == "Администратор")
                {
                    Admin page = new Admin(user.user_fullname);
                    page.Show();
                    this.Close();
                }
                else if (user.user_role == "Менеджер")
                {
                    Manager page = new Manager(user.user_fullname);
                    page.Show();
                    this.Close();
                }
                else if (user.user_role == "Клиент")
                {
                    UserPage page = new UserPage(user.user_fullname);
                    page.Show();
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Ошибка!", $"Неверный логин или пароль!");
            }
        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            Products page = new Products();
            page.Show();
            this.Close();
        }
    }
}
