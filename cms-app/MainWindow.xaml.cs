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

namespace cms_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // createStudent();
        }

        /*  public void createStudent()
          {
              DatabaseRepository repository = new DatabaseRepository();
              Student student1 = new Student()
              {
                  firstName = "Achila",
                  lastName = "Sandeep",
                  email = "achilasandeep@gmail.com",
                  contactNo = 0123456789,
                  password = "achila123",
                  dateofbirth = 23,

              };

                      }
      }*/
    }
}