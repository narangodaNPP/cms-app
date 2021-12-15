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
    /// Interaction logic for teacherDashboard.xaml
    /// </summary>
    public partial class teacherDashboard : Window
    {
        public teacherDashboard()
        {
            InitializeComponent();
            retrew();
        }
        public void retrew()
        {

            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault() != null)
            {


                var user = LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault();

                txtname.Content = "Hello " + " " + user.firstName + " " + user.lastName;

            }
        }
        private void createClassButton_Click(object sender, RoutedEventArgs e)
        {
            myDashboardFrame.Content = new create_class();
        }

        private void paymentButton_Click(object sender, RoutedEventArgs e)
        {
            myDashboardFrame.Content = new payments_view();
        }

        private void studentButton_Click(object sender, RoutedEventArgs e)
        {
            myDashboardFrame.Content = new students_view();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            myDashboardFrame.Content = new teacher_home();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            landingWindow landing = new landingWindow();
            landing.Show();
            this.Close();

        }
    }
}
