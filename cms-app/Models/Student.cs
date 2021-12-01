using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Models
{
    class Student
    {
        [Key]
        public string studentID { get; set; }

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
        public int age { get; set; }
    }
}
