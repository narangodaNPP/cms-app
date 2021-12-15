using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Models
{
    public class Allclasses
    {
        [Key]
        public int classID { get; set; }
        
        [Required]
        public string subject { get; set; }

        [Required]
        public int teacherid { get; set; }

        [Required]
        public string day { get; set; }

        [Required]
        public string classname { get; set; }
        public string duration { get; set; }
        public string classfree { get; set; }



    }
}
