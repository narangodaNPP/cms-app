using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }

        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public int contactNo { get; set; }

        [Required]
        public string password { get; set; }
        public DateTime dateofbirth { get; set; }
        public string myclasses { get; set; }

       
    }
}
