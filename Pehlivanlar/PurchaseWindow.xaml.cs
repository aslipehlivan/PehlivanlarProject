﻿using Pehlivanlar.Data;
using Pehlivanlar.User;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class PurchaseWindow : Window
    {
        PehlivanlarDb db = new PehlivanlarDb();
        public PurchaseWindow()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var categories = db.Categories.OrderBy(c => c.Name).ToList(); //Databaseden kategorileri çekip isme göre sıralar.
            cbCategories.ItemsSource = categories;

        }

        private void cbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategory = cbCategories.SelectedItem as Category;
            var code = db.Products.Where(p => p.CategoryID == ((Category)cbCategories.SelectedItem).ID).OrderBy(p => p.Code).ToList(); //Kategori comboboxından seçilen kategoriye ait ürünleri koduna göre sıralar.
            cbCodes.ItemsSource = code;

        }

        private void cbCodes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(p => p.ID == ((Product)cbCodes.SelectedItem).ID); //Seçilen ürünü tutar.
            lblStock.Content = "Stok adedi: " + product.Stock; //Seçili ürünün stoğunu gösterir.
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(p => p.ID == ((Product)cbCodes.SelectedItem).ID); //Seçilen ürün

            var selectedCode = cbCodes.SelectedItem as Product;
            if (selectedCode == null)
            {
                MessageBox.Show("Ürün kodu seçiniz");
                return;
            }
            else
            {
                product.Stock += Int32.Parse(txtAmount.Text);
                db.Update(product);
                db.SaveChanges();
                MessageBox.Show("Stok güncellendi.");
                lblStock.Content = "Stok adedi: " + product.Stock; //Güncel stoğu gösterir.
            }

            
        }
    }
}
