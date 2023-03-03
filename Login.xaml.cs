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
using System.Windows.Shapes;

namespace PP_Login
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static string SetName = "";
        public static string SetUsername = "";
        public static string SetPassword = "";

        public static string Username = "";
        public static string Password = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnRegist_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SetName = Register.SetName;
            SetUsername = Register.SetUser;
            SetPassword = Register.SetPassword;

            Username = boxUser.Text;
            Password = boxPass.Password;

            if (Username != "" && Password != "")
            {
                if (Username == SetUsername)
                {
                    if (Password == SetPassword)
                    {
                        MessageBox.Show("Login Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow MainWindow = new MainWindow();
                        MainWindow.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Inccorect Username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Input Email and Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
