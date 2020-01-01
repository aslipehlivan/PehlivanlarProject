using Pehlivanlar.Data;
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
            var categories = db.Categories.OrderBy(c => c.Name).ToList(); //databaseden ürünün kategorisini çekmek için
            cbCategories.ItemsSource = categories;
            cbCodes_SelectionChanged(categories, );
            var code = db.Products.OrderBy(p => p.Code).ToList(); //databaseden ürünün kodunu çekmek için
            cbCodes.ItemsSource = code;
        }

        private void cbCodes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(c => c.CategoryID == ((Category)cbCodes.SelectedItem).ID); //combodan seçilen ürünü çeker.

        }
    }
}
