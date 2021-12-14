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

 
        /*public void add()
{
   DatabaseRepository repository = new DatabaseRepository();

   teacher teacher = new teachers()
   {



       firstName = txtfirstname.Text,
       lastName = txtlastname.Text,
       email = txtemail.Text,
       contactNo = Convert.ToInt32(txtcontactno.Text),
       password = txtpassword.Password,
       dateofbirth = txtdateofbirth.SelectedDate.Value,






   };
   repository.Students.Add(student);
   repository.SaveChanges();

   MessageBox.Show("Successfully Registerd!!");

}*/
    }
}
