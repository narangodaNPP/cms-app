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
    /// Interaction logic for create_class.xaml
    /// </summary>
    public partial class create_class : Page
    {
        public create_class()
        {
            InitializeComponent();
            
        }
        public void add()
        {
            DatabaseRepository repository = new DatabaseRepository();

            var user = repository.teachers.Where(a => a.teacherID == Global.userid).FirstOrDefault();

           
            var teachername = user.firstName + " " + user.lastName;

            Allclasses allclasses = new Allclasses()
            {



                subject = txtsubject.Text,
                day = txtday.Text,
                classname = txtname.Text,
                classfree = txtfree.Text,
                teacher = teachername,
                teacherID = Global.userid



            };
            repository.classes_set.Add(allclasses);
            repository.SaveChanges();

            MessageBox.Show("Successfully create class");
            


        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            add();
            

        }

       
    }
}
