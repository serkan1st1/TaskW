using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Worker
    {
        [Key]
        public int WorkerID { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(40)]
        public string Surname { get; set; }

        public int TC { get; set; }

        public string CompanyName { get; set; }
        public virtual Company Company { get; set; }
    }
}
