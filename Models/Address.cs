using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Street { get; set; }

        public int Number{ get; set; }
        public int Code{ get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Hood{ get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string City{ get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string State{ get; set; }
    }
}
