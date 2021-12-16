﻿using cms_app.Database;
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
    /// Interaction logic for student_home.xaml
    /// </summary>
    public partial class student_home : Page
    {
        public student_home()
        {
            InitializeComponent();
            retrew();

        }

        public void retrew()
        {

            DatabaseRepository LoginLogCtx = new DatabaseRepository();

            if (LoginLogCtx.Students.Where(a => a.studentID == Global.userid).FirstOrDefault() != null)
            {


                var user = LoginLogCtx.Students.Where(a => a.studentID == Global.userid).FirstOrDefault();

                txtemail.Text = user.email;
                txtcontacno.Text = user.contactNo;
                password.Text = user.password;
                name.Content = user.firstName +" "+ user.lastName;



            }
        }
        public void add()
        {
            DatabaseRepository repository = new DatabaseRepository();

            Student student = new Student()
            {


                email = txtemail.Text,
                contactNo = txtcontacno.Text,
                password = password.Text,


            };
        }
            private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            add();
            
        }
    }
}
