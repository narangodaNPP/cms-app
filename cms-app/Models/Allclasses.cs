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
        
       
        public string subject { get; set; }

        
        public string teacher { get; set; }

        
        public string day { get; set; }

        
        public string classname { get; set; }
        
        public string classfree { get; set; }



    }
}
