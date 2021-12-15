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
    /// Interaction logic for teacher_home.xaml
    /// </summary>
    public partial class teacher_home : Page
    {
        public teacher_home()
        {
            InitializeComponent();
        }
        public void retrew()
        {

            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault() != null)
            {


                var user = LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault();

                //txtfirstname.Text = user.firstName;

            }
        }
    }
}
