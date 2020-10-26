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
        public Type Type { get; set; }
    }

    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Name { get; set; }
    }
}
