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

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for TvWindow.xaml
    /// </summary>
    public partial class TvWindow : Window
    {
        private Product product;
        public TvWindow(Product product)
        {
            PehlivanlarDb db = new PehlivanlarDb();
            var productnew = db.Products.Find(product.ID);
            TV1.Content = productnew.Code;
            InitializeComponent();

        }
        
    }
}
