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
using Microsoft.Data.SqlClient;
using System.Linq;
using Pehlivanlar.User;

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for AddNewProductWindow.xaml
    /// </summary>
    public partial class AddNewProductWindow : Window
    {
        PehlivanlarDb db = new PehlivanlarDb();
        public AddNewProductWindow()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {

            Product product = new Product();
            product.Code = txtCode.Text;
            product.Color = txtColor.Text;
            product.Properties = txtProperties.Text;
            product.Stock = Int32.Parse(txtAmount.Text);

            var selectedCategory = cbCategories.SelectedItem as Category;
            if (selectedCategory == null)
            {
                MessageBox.Show("Kategori seçiniz");
                return;
            }
            product.CategoryID = selectedCategory.ID;

            var selectedSupplier = cbSuppliers.SelectedItem as Supplier;
            if (selectedSupplier == null)
            {
                MessageBox.Show("Firma seçiniz");
                return;
            }
            product.SupplierID = selectedSupplier.ID;

            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Yeni ürün eklendi.");

            txtCode.Text = "";
            txtColor.Text = "";
            txtProperties.Text = "";
            txtAmount.Text = "";

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var categories = db.Categories.OrderBy(c => c.Name).ToList();
            cbCategories.ItemsSource = categories;

            var suppliers = db.Suppliers.OrderBy(s => s.Name).ToList();
            cbSuppliers.ItemsSource = suppliers;

        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
