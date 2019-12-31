using Pehlivanlar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pehlivanlar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            PehUserService pehUserService = new PehUserService();
            var loginUser = pehUserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
            else
            {
                //Userı diğer ekranlarda kullanabilmek için App.Current.Properties["User"] şeklinde atama yapıldı
                //https://stackoverflow.com/questions/1161459/wpf-application-using-a-global-variable
                App.Current.Properties["User"] = loginUser;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
