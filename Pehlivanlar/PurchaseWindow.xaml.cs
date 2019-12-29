using Pehlivanlar.Data;
using Pehlivanlar.User;
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

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class PurchaseWindow : Window
    {

        public PurchaseWindow()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void dgPurchase_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Categories categories = dgPurchase.SelectedItem as Categories;
            if (categories != null)
            {

            }
        }
    }
}
