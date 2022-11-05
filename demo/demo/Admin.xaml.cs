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
using System.Windows.Shapes;

namespace demo
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin(string fullname)
        {
            InitializeComponent();
            FullName.Text = fullname;
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow page = new MainWindow();
            this.Close();
            page.Show();
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            ProductsAdmin page = new ProductsAdmin();
            this.Close();
            page.Show();
        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            Orders page = new Orders();
            this.Close();
            page.Show();
        }
    }
}
