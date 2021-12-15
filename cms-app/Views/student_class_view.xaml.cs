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
    /// Interaction logic for student_class_view.xaml
    /// </summary>
    public partial class student_class_view : Page
    {
        public student_class_view()
        {
            InitializeComponent();
             
        }

        public void load()
        {

            DatabaseRepository repository = new DatabaseRepository();

            var cartList = repository.classes_set.Where(a => a.subject == FilledComboBox.Text).ToList();
            classgride.ItemsSource = cartList;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            load();
        }
    }
}
