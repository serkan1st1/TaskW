using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(150)]
        public string TaxAdministration { get; set; }

        public int TaxNumber { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
    }
}
