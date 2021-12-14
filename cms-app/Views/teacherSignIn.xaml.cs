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
    /// Interaction logic for teacherSignIn.xaml
    /// </summary>
    public partial class teacherSignIn : Window
    {
        public teacherSignIn()
        {
            InitializeComponent();
        }

        DatabaseRepository LoginLogCtx = new DatabaseRepository();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginLogCtx.teachers.Where(a => (a.email == txtemail.Text) && (a.password == txtpassword.Password)).FirstOrDefault() != null)
            {

                var user = LoginLogCtx.teachers.Where(a => (a.email == txtemail.Text) && (a.password == txtpassword.Password)).FirstOrDefault();
                Global.userid = user.teacherID;
                Global.st = "t";

                teacherDashboard teachDashboard = new teacherDashboard();
                teachDashboard.Show();
                this.Close();

            }
        }
    }
}
