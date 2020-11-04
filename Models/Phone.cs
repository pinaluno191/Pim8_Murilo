using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        public int DDD { get; set; }

        public Tipo Name { get; set; }   
        
        public List<PersonPhone> PersonPhones { get; set; }

    }
    public class Tipo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
