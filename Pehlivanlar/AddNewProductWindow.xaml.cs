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

        public SqlDataReader Sdr { get; private set; }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {

            Product product = new Product();
            product.Code = txtCode.Text;
            product.Color = txtColor.Text;
            product.Properties = txtProperties.Text;
           // product.CategoryID = Convert.ToInt32(cbCategories.SelectedItem);

            var selectedCategory = cbCategories.SelectedItem as Category;
            if (selectedCategory == null)
            {
                MessageBox.Show("Kategori seçiniz");
                return;
            }

            product.CategoryID = selectedCategory.ID;

            db.Products.Add(product);
                db.SaveChanges();

                MessageBox.Show("Yeni ürün eklendi.");  

        }





        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var categories = db.Categories.OrderBy(c => c.Name).ToList();
            cbCategories.ItemsSource = categories;

            var suppliers = db.Suppliers.OrderBy(s => s.Name).ToList();
            cbSuppliers.ItemsSource = suppliers;

        }

        //private void cbCategories_Selected(object sender, RoutedEventArgs e)
        //{
        //    var selectedCategory = cbCategories.SelectedItem as Category;
        //    if (selectedCategory == null)
        //    {
        //        MessageBox.Show("Kategori seçiniz");
        //        return;
        //    }

        //    product  = selectedDepartmen.Id;
        //}
    }
}
