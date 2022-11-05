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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        string fullname;
        private Product _product;

        public AddOrder(object selectedItem, string name)
        {
            InitializeComponent();
            fullname = name;
            _product = selectedItem as Product;
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            Product.Text = _product.product_name.ToString();
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            using (DemoEntities db = new DemoEntities())
            {
                Order r = new Order();
                r.order_start_date = DateTime.Now;
                r.order_delivery_date = DeliveryId.SelectedDate;
                r.point_id = int.Parse(Point.Text);
                r.order_user_fullname = fullname;
                r.order_status = "Новый";
                r.order_code = 201;
                r.order_elements = _product.product_articule + " " + _product.product_id;

                db.Orders.Add(r);
                db.SaveChanges();
            }
        }
    }
}
