using cms_app.Database;
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
    /// Interaction logic for signIn.xaml
    /// </summary>
    public partial class signIn : Window
    {
        public signIn()
        {
            InitializeComponent();
        }


       

        private void signin_Click(object sender, RoutedEventArgs e)
        {
            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.Students.Where(a => (a.email == txtemail.Text) && (a.password == txtpassword.Password)).FirstOrDefault() != null)
            {

                var user = LoginLogCtx.Students.Where(a => (a.email == txtemail.Text) && (a.password == txtpassword.Password)).FirstOrDefault();
                Global.userid = user.studentID;
                Global.st = "s";


                studentDashboard studDashboard = new studentDashboard();
                studDashboard.Show();
                this.Close();

            }
           


        }

        private void signup_click(object sender, RoutedEventArgs e)
        {
            signUp signup = new signUp();
            signup.Show();
            this.Close();
        }
    }
}
