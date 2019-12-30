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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PehUser loginUser;

        public MainWindow(PehUser pehUser)
        {
            loginUser = pehUser;
            InitializeComponent();
        }
       
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtLoginUser.Text = "Merhaba " + loginUser.Name + " " + loginUser.Surname + "\n " + "Rolünüz: " + loginUser.Role.Name;
            SetUserMenuAccordingTRole(loginUser.Role);
        }

        private void SetUserMenuAccordingTRole(Role role)
        {
            mnChangePassword.Visibility = role.CanChangePassword ? Visibility.Visible : Visibility.Hidden;
            mnChangePassword.IsEnabled = role.CanChangePassword;
        }

        private void mnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow(loginUser);
            changePasswordWindow.ShowDialog();
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (loginUser.RoleID == 1)
            {
                PurchaseWindow purchaseWindow = new PurchaseWindow();
                purchaseWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Bu işlem için erişiminiz bulunmamaktadır.");
            }

        }

        private void btnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            if (loginUser.RoleID == 1)
            {
                AddNewProductWindow addNewProductWindow = new AddNewProductWindow();
                addNewProductWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu işlem için erişiminiz bulunmamaktadır.");
            }

        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            SaleWindow saleWindow = new SaleWindow();
            saleWindow.Show();
            this.Close();
        }

        private void mnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Hesabınızdan çıkmak istediğinize emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                this.Close();
            }

        }

        private void mnUserInfo_Click(object sender, RoutedEventArgs e)
        {
            UserWindow1 userWindow1 = new UserWindow1(loginUser);
            userWindow1.Show();
            this.Close();
        }

        private void mnNewUser_Click(object sender, RoutedEventArgs e)
        {
            if (loginUser.RoleID == 1)
            {
                NewUserWindow newUserWindow = new NewUserWindow();
                newUserWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu işlem için erişiminiz bulunmamaktadır.");
            }

        }
    }
}
