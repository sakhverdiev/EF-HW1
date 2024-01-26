using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    public class Deparment
    {
        [Key]
        public int Id { get; set; }
        [Required,NotNull]
        [Range(1, 5)]
        public int Building { get; set; }
        [Range(0, int.MaxValue)] 
        [DefaultValue(0)]
        public Double Financing{ get; set; }

        [Column(TypeName ="nvarchar(100)")]
        [Required, NotNull]

        public string Name { get; set; }

        [Required, NotNull]
        [ForeignKey(nameof(Faculity))]
        public int FaculityId { get; set; }
        public Faculity Faculity { get; set; }

    }
}
