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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cms_app.Views
{
    /// <summary>
    /// Interaction logic for personal_details.xaml
    /// </summary>
    public partial class personal_details : Page
    {
        public personal_details()
        {
            InitializeComponent();
            retrew();
        }
        public void retrew() {

            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.Students.Where(a => a.studentID == Global.userid).FirstOrDefault() != null)
            {


                var user = LoginLogCtx.Students.Where(a => a.studentID == Global.userid).FirstOrDefault();

                txtfirstname.Text = user.firstName;

            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //course_details coursedetails = new course_details();
            //coursedetails.Show();
            //this.close();
        }
    }
}
