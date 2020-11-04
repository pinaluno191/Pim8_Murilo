using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class PersonPhone
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }

    }
}
