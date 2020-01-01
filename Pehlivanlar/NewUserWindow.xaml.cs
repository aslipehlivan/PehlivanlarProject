using Pehlivanlar.Data;
using Pehlivanlar.User;
using Pehlivanlar.Service;
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
    /// Interaction logic for NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        public NewUserWindow()
        {
            InitializeComponent();
        }
        PehlivanlarDb db = new PehlivanlarDb();

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            PehUser pehUser = new PehUser();
            pehUser.Name = txtName.Text;
            pehUser.Surname = txtSurname.Text;
            pehUser.UserName = txtUserName.Text;

            pehUser.Password = new Service.PehUserService().hashPassword(pwPassword.Password);
            var selectedRole = cbUserRole.SelectedItem as Role;
            if (selectedRole == null)
            {
                MessageBox.Show("Rol seçiniz");
                return;
            }
            pehUser.RoleID = selectedRole.ID;
            
            db.PehUsers.Add(pehUser);
            db.SaveChanges();

            MessageBox.Show("Yeni kullanıcı oluşturuldu.");

            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var userRole = db.Roles.OrderBy(r => r.Name).ToList();
            cbUserRole.ItemsSource = userRole;

        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


    }
}
