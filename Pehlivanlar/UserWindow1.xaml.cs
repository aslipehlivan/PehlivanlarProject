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
    /// Interaction logic for UserWindow1.xaml
    /// </summary>
    public partial class UserWindow1 : Window
    {
        private PehUser loginUser;
        public UserWindow1(PehUser pehUser)
        {
            loginUser = pehUser;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtloginUserName.Text = loginUser.Name;
            txtloginUserSurname.Text = loginUser.Surname;
            txtloginUserRole.Text = loginUser.Role.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(loginUser);
            mainWindow.Show();
            this.Close();
        }

        private void btnUpdateName_Click(object sender, RoutedEventArgs e)
        {
            PehlivanlarDb db = new PehlivanlarDb();
            var pehusernew = db.PehUsers.Find(loginUser.ID);
            pehusernew.Name = txtloginUserName.Text;
            db.SaveChanges();
        }

        private void btnUpdateSurname_Click(object sender, RoutedEventArgs e)
        {
            PehlivanlarDb db = new PehlivanlarDb();
            var pehuserNew = db.PehUsers.Find(loginUser.ID);
            pehuserNew.Surname = txtloginUserSurname.Text;
            db.SaveChanges();
        }
    }
}
