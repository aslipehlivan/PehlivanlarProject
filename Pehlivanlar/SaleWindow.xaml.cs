using Microsoft.Data.SqlClient;
using Pehlivanlar.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
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

   
    }
}
