using Pehlivanlar.Service;
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
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        PehUserService pehUserService = new PehUserService();
        private readonly PehUser pehUser;

        public ChangePasswordWindow(PehUser pehUser)
        {
            InitializeComponent();
            this.pehUser = pehUser;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (!pehUserService.CheckPassword(pehUser, txtCurrentPassword.Text))
            {
                MessageBox.Show("Mevcut şifreniz hatalı.");
            }
            if (txtNewPassword.Text.Length < 5)
            {
                MessageBox.Show("Şifre 5 karakterden uzun olmalıdır.");
            }
            if (txtNewPassword.Text != txtNewPasswordAgain.Text)
            {
                MessageBox.Show("Yeni şifreler uyumlu değil.");
            }
            if (txtNewPassword.Text == txtCurrentPassword.Text)
            {
                MessageBox.Show("Yeni şifre eski şifre ile aynı olamaz.");
            }
            else
            {
                pehUserService.ChangePassword(pehUser, txtNewPassword.Text);
                MessageBox.Show("Şifreniz başarılı bir şekilde değiştirildi!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
