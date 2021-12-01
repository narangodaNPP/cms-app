using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms_app.Models
{
    class Payment
    {
        [Key]
        public int paymentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string paymentMethod { get; set; }

        public string cardNumber { get; set; }
        public string expireMonth { get; set; }
        public string expireYear { get; set; }
        public string securityCode { get; set; }
        public string paymentDate { get; set; }
    }
}
