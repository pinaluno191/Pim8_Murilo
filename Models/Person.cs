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

        public string Name { get; set; }

        public long CPF { get; set; }

        public  List<Address> Address { get; set; }       

        public  List<PersonPhone> PersonPhones {get;set;}


        

    }
}
