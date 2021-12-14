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

            Allclasses allclasses = new Allclasses()
            {



                subject = txtsubject.Text,
                day = txtday.Text,
                duration = txtduration.Text,
                classfree = txtclassfree.Text,



            };
            repository.classes_set.Add(allclasses);
            repository.SaveChanges();
        }
    }
}
