﻿using cms_app.Database;
using cms_app.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();

        }



        private void txtsubject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DatabaseRepository reposi = new DatabaseRepository();

            List<Allclasses> teachers = reposi.classes_set.Where(a => a.subject == txtsubject.Text).ToList();

            Trace.WriteLine("hbshkvb " + teachers.Count());
            List<string> ateacher = new List<string>();

            foreach (Allclasses teacher in teachers) {

                ateacher.Add(teacher.teacher);
                //txtteacher.Items.Add(teacher.teacher);
                Trace.WriteLine(teacher.teacher);
            }
            txtteacher.ItemsSource = ateacher;
        }

        private void txtteacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Trace.WriteLine(txtteacher.Text + "fgsdfhs");
            DatabaseRepository reposi = new DatabaseRepository();

            List<Allclasses> teachers = reposi.classes_set.Where(a => a.subject == txtsubject.Text && a.teacher == txtteacher.Text).ToList();

            Trace.WriteLine("hbshkvb" + teachers.Count());
            List<string> ateacher = new List<string>();

            foreach (Allclasses teacher in teachers)
            {

                ateacher.Add(teacher.teacher);
                //txtteacher.Items.Add(teacher.teacher);
                Trace.WriteLine(teacher.teacher);
            }
            txtclass.ItemsSource = ateacher;
        }


        public void add()
        {
            DatabaseRepository repository = new DatabaseRepository();

            var teachers = repository.classes_set.Where(a => a.subject == txtsubject.Text && a.teacher == txtteacher.Text && a.classname == txtclass.Text).FirstOrDefault();

            var id = teachers.classID;

            studentclass studentclasses = new studentclass()
            {
                classID = id,
                studentID = Global.userid


            };


            
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            add();
        }
    } }
