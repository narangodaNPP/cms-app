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
        public string teacher { get; set; }

        [Required]
        public string date { get; set; }

        [Required]
        public string time { get; set; }



    }
}
