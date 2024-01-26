using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required, NotNull]
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

    }
}