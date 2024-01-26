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
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required, NotNull] 
        public string Name { get; set; }

        [Required, NotNull]
        [Range(1,5)]
        public int Year { get; set; }

        [Required, NotNull]
        [ForeignKey(nameof(Deparment))]
        public int DepartmentId { get; set; }

        public Deparment Deparment { get; set; }


    }
}
