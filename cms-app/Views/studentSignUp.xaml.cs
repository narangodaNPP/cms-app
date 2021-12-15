using cms_app.Database;
using cms_app.Models;
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
        public void add()
        {
            DatabaseRepository repository = new DatabaseRepository();

            Student student = new Student()
            {
                

                
                firstName = txtfirstname.Text,
                lastName  = txtlastname.Text,
                email     = txtemail.Text,
                contactNo = Convert.ToInt32(txtcontactno.Text),
                password  = txtpassword.Password,
                dateofbirth = txtdateofbirth.SelectedDate.Value,
                             





            };
            repository.Students.Add(student);
            repository.SaveChanges();

            MessageBox.Show("Successfully Registerd!!");

        }
        public void saveid()
        {
            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            

                var user = LoginLogCtx.Students.Where(a => a.email == txtemail.Text).FirstOrDefault();
                Global.userid = user.studentID;
                Global.st = "s";


            



        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            add();
            saveid();
            studentDashboard sdash = new studentDashboard();
            sdash.Show();
            this.Close();
        }

        private void signin_Click(object sender, RoutedEventArgs e)
        {
            signIn signin = new signIn();
            signin.Show();
            this.Close();
        }


    }
}
