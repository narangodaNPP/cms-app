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

namespace cms_app.Views
{
    /// <summary>
    /// Interaction logic for landingWindow.xaml
    /// </summary>
    public partial class landingWindow : Window
    {
        public landingWindow()
        {
            InitializeComponent();
        }

        private void logoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            signIn signin = new signIn();
            signin.Show();

            this.Close();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            signUp signup = new signUp();
            signup.Show();

            this.Close();
        }
    }
}
