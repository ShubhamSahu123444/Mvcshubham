using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Mvcshubham.Models
{
    public class Customer
    {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public Location Location { get; set; }

    }

}
