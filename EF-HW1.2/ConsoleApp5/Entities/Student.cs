using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required,NotNull]
        [Column(TypeName ="nvarchar(Max)")]
        public string? Name { get; set; }

        [Required,NotNull]
        [Range(0,5)]
        public int Rating { get; set; }

        [Required,NotNull]
        [Column(TypeName ="nvarhcar(Max)")]
        public string? Surname { get; set; }
        
    }
}