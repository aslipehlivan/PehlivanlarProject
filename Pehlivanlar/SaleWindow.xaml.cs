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
            var codes = db.Products.OrderBy(p => p.Code).ToList(); //databaseden ürünleri çekip kodlarına göre sıralar.
            cbCodes.ItemsSource = codes;
        }

        private void btnUpdateStock_Click(object sender, RoutedEventArgs e)
        {
            var selectedCode = cbCodes.SelectedItem as Product;
            if (selectedCode == null)
            {
                MessageBox.Show("Ürün kodu seçiniz");
                return;
            }

            Product product = db.Products.FirstOrDefault(p => p.ID == selectedCode.ID); //databaseden ürünleri çekip comboboxdan seçilen ürünün IDsiyle aynı olanı seçer.
            if (product.Stock >= Int32.Parse(txtAmount.Text))
            {
                product.Stock -= Int32.Parse(txtAmount.Text);
                db.Update(product);
                db.SaveChanges();
                lblStock.Content = "Stok adedi: " + product.Stock;
                MessageBox.Show("Stok güncellendi."); 

            }
            else
            {
                MessageBox.Show("Yeterli stok bulunamadı.");
            }
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void cbCodes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(p => p.ID == ((Product)cbCodes.SelectedItem).ID); //combodan seçilen ürünü çeker.
            lblStock.Content = "Stok adedi: " + product.Stock;
        }
    }
    
}
