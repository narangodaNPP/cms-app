using cms_app.Database;
using System;
using cms_app.Models;
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
    /// Interaction logic for teacherSignUp.xaml
    /// </summary>
    public partial class teacherSignUp : Window
    {
        public teacherSignUp()
        {
            InitializeComponent();
        }

 
        public void add(){
        DatabaseRepository repository = new DatabaseRepository();

        teacher Teacher = new teacher()
        {
            firstName = txtfirstname.Text,
            lastName = txtlastname.Text,
            email = txtemail.Text,
            contactNo = Convert.ToInt32(txtcontactno.Text),
            password = password.Password,
            dateofbirth = dateofbirth.SelectedDate.Value,
            
        };
        repository.teachers.Add(Teacher);
        repository.SaveChanges();

        MessageBox.Show("Successfully Registerd!!");

        
        }
        public void saveid()
        {
            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            

                var user = LoginLogCtx.teachers.Where(a => a.email == txtemail.Text).FirstOrDefault();
                Global.userid = user.teacherID;
                Global.st = "t";

                

            
        }


        private void btnTeacherSignup_Click(object sender, RoutedEventArgs e)
        {
            add();
            saveid();
            teacherDashboard teasigni = new teacherDashboard();
            teasigni.Show();
            this.Close();
        }

        private void btnTeacherSignin_Click(object sender, RoutedEventArgs e)
        {
            studentSignIn signin = new studentSignIn();
            signin.Show();
            this.Close();
        }
    }
}
