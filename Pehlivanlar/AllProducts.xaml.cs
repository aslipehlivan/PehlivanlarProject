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
using Microsoft.EntityFrameworkCore;
using Pehlivanlar.Data;

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for AllProducts.xaml
    /// </summary>
    public partial class AllProducts : Window
    {
        public AllProducts()
        {
            InitializeComponent();
            using (PehlivanlarDb db = new PehlivanlarDb())
            {
                dgProducts.ItemsSource = db.Products.Include(i => i.Category).Include(i => i.Supplier).ToList(); //Foreign keylerle bağlantı bu kodla kuruluyor.
            }
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
