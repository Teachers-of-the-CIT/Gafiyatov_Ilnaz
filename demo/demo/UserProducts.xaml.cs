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
    /// Interaction logic for UserProducts.xaml
    /// </summary>
    public partial class UserProducts : Window
    {
        string fullname;

        public UserProducts(string name)
        {
            InitializeComponent();
            fullname = name;

            ProductsTable.ItemsSource = DemoEntities.GetContext().Products.ToList();
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsTable.SelectedItem != null)
            {
                AddOrder a = new AddOrder(ProductsTable.SelectedItem, fullname);
                a.Show();
                this.Close();
            }
        }
    }
}
