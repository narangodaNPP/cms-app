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
            load();
            retrew();
        }
        //public void retrew()
        //{

        //    DatabaseRepository LoginLogCtx = new DatabaseRepository();

        //    if (LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault() != null)
        //    {


        //        var user = LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault();

        //        //txtfirstname.Text = user.firstName;

        //    }
            
        //}
        public void load()
        {

            DatabaseRepository repository = new DatabaseRepository();

            var cartList = repository.classes_set.Where(a => a.teacherID == Global.userid).ToList();
            classgride.ItemsSource = cartList;


        }
        public void retrew()
        {

            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault() != null)
            {


                var user = LoginLogCtx.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault();

                txtemail.Text = user.email;
                txtcontacno.Text = user.contactNo;
                password.Text = user.password;
                name.Content = user.firstName + " " + user.lastName;



            }
        }
        public void add()
        {
            DatabaseRepository repository = new DatabaseRepository();

            teacher Teacher = new teacher()
            {


                email = txtemail.Text,
                contactNo = txtcontacno.Text,
                password = password.Text,


            };
        }
        

        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            add();
        }
    }
}

