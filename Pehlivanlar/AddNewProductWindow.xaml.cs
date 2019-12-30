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
           // if ()
           // {
                Product product = new Product();
                product.Code = txtCode.ToString();
                product.Color = txtColor.ToString();
                product.Properties = txtProperties.ToString();
                product.SupplierID = 1;
                

                db.Products.Add(product);
                db.SaveChanges();

                MessageBox.Show("Yeni ürün eklendi.");
           // }
           

            MessageBox.Show("Yeni ürün eklendi.");
        }

        private void cbBeko_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.SupplierID = 1;
        }

        private void cbVestel_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.SupplierID = 2;
        }

        private void cbTelevizyon_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 1;
        }

        private void cbBuzdolabı_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 2;
        }

        private void cbCamasir_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 3;
        }

        private void cbBulaik_Selected(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 4;
        }

        private void cbTV(object sender, DataObjectCopyingEventArgs e)
        {
            Product product = new Product();
            product.CategoryID = 1;
        }

        private void cbCategories_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
     
            SqlCommand cmd = new SqlCommand("select Code from Categories");
            Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cbCategories.Items.Add(Sdr.GetString(i));

                }
            }
            MessageBox.Show(Sdr.FieldCount.ToString());

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

                var departments = db.Categories.OrderBy(d => d.Name).ToList();
                cbCategories.ItemsSource = departments;
           
        }
    }
}
