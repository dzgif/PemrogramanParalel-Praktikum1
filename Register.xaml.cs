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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public static string SetName = "";
        public static string SetUser = "";
        public static string SetPassword = "";
        public static string SetCPass = "";

        public Register()
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
            SetName = boxName.Text;
            SetUser = BoxUser.Text;
            SetPassword = boxPass.Password;
            SetCPass = boxCPass.Password;

            if (SetName != "" && SetUser != "" && SetPassword != "" && SetCPass != "")
            {
                if (SetPassword == SetCPass) 
                {
                    MessageBox.Show("Register Success!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    boxName.Text = "";
                    BoxUser.Text = "";
                    boxPass.Password = "";
                    boxCPass.Password = "";
                }
                else
                {
                    MessageBox.Show("Password doesnt Match!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    boxPass.Password = "";
                    boxCPass.Password = "";
                }
            }
            else
            {
                MessageBox.Show("Data Empty!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void goLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
