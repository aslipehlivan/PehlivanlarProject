using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pehlivanlar.Data;
using Microsoft.EntityFrameworkCore;


namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for AddNewProductWindow.xaml
    /// </summary>
    public partial class AddNewProductWindow : Window
    {
        public AddNewProductWindow()
        {
            InitializeComponent();
        }
        PehlivanlarDb db = new PehlivanlarDb();

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Code = txtCode.ToString();
            product.Color = txtColor.ToString();
            product.Properties = txtProperties.ToString();
            

            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Yeni ürün eklendi.");
        }

        private void cbBeko_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 1;
        }
    }
}
