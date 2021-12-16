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
    /// Interaction logic for students_view.xaml
    /// </summary>
    public partial class students_view : Page
    {
        public students_view()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {

            DatabaseRepository repository = new DatabaseRepository();

            var classest = repository.classes_set.Where(a => a.teacherID == Global.userid).ToList();
            classes.ItemsSource = classest;


        }
    }
}
