﻿using System;
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
    /// Interaction logic for studentDashboard.xaml
    /// </summary>
    public partial class studentDashboard : Window
    {
        public studentDashboard()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            myStudentDashboardFrame.Content = new student_home();
        }

        private void classButton_Click(object sender, RoutedEventArgs e)
        {
            myStudentDashboardFrame.Content = new student_class_view();
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
