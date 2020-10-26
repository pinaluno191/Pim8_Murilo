using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Name { get; set; }

        public int CPF { get; set; }

        public Address Address { get; set; }

        public Phone Phone { get; set; }
        

    }
}
