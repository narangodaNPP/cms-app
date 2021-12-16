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
    /// Interaction logic for course_details.xaml
    /// </summary>
    public partial class course_details : Page
    {

        public course_details()
        {
            InitializeComponent();
            bindcombo();
        }

        public List<Allclasses> teacher { get; set; }
        private void bindcombo() {

            DatabaseRepository reposi = new DatabaseRepository();
            var item = reposi.classes_set.ToList();
            teacher = item;
            DataContext = teacher;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bindcombo();
        }
    }
}
