using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5.Entities
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue(0)]
        public bool Professor { get; set; }

        [Required, NotNull]
        [Column(TypeName = "nvarchar(Max)")]
        public string? Name { get; set; }

        [Required, NotNull]
        [Column(TypeName = "nvarchar(Max)")]
        public string? Surname { get; set; }

        [Required, NotNull]
        [Range(1,int.MaxValue)]
        public Double Salary { get; set; }

    }
}