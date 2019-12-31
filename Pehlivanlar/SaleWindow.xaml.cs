using Microsoft.Data.SqlClient;
using Pehlivanlar.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for SaleWindow.xaml
    /// </summary>
    public partial class SaleWindow : Window
    {
        PehlivanlarDb db = new PehlivanlarDb();
        public SaleWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var codes = db.Products.OrderBy(p => p.Code).ToList();
            cbCodes.ItemsSource = codes;
        }

        private void btnUpdateStock_Click(object sender, RoutedEventArgs e)
        {

            Product product = new Product();
            var selectedCode = cbCodes.SelectedItem as Product;
            if (selectedCode == null)
            {
                MessageBox.Show("Kategori seçiniz");
                return;
            }
            product.CategoryID = selectedCode.ID;
            product.Stock -= Int32.Parse(txtAmount.Text);
            db.Update(product);
            db.SaveChanges();
            MessageBox.Show("Stok güncellendi.");
        }
    }
    
}
