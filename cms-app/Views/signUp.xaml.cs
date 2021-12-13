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
    /// Interaction logic for signUp.xaml
    /// </summary>
    public partial class signUp : Window
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {
            studentDashboard stud = new studentDashboard();
            stud.ShowDialog();
            this.Close();

        }

        private void signinButton_Click(object sender, RoutedEventArgs e)
        {
            signIn signin = new signIn();
            signin.Show();
            this.Close();
        }
    }
}
