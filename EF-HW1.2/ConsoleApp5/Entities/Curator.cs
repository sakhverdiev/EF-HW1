using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    public class Curator
    {
        [Key] 
        public int MyProperty { get; set; }
        [Required, NotNull]
        [Column(TypeName = "nvarchar(Max)")]
        public string Name { get; set; }

        [Required, NotNull]
        [Column(TypeName = "nvarchar(Max)")]
        public string Surname { get; set; }

    }
}
