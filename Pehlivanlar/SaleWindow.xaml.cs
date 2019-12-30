using Microsoft.Data.SqlClient;
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
        public SaleWindow()
        {
            InitializeComponent();
            bidDataGrid();
        }

        //private void bidDataGrid()
        //{
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        //    connection.Open();
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "select * from [Categories]";
        //    command.Connection = connection;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTemplate dt = new DataTemplate ("Categories");
        //    da.Fill(dt);

        //}
    }
}
