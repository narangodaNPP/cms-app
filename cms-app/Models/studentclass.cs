using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Models
{
    public class studentclass
    {

        [Key]
        public int clID { get; set; }
        public int studentID { get; set; }
        public int classID { get; set; }



    }
}
