using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ConsoleApp5.Entities
{
    public class Lecture
    {
        [Key]
        public int Id { get; set; }

        [Required,NotNull] 
        [Range(typeof(DateTime),minimum:"01-01,2000",maximum: "1-1-2024")]
        public DateTime Date{ get; set; }

        [Required,NotNull]
        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        [Required, NotNull]
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public Subject? Subject { get; set; }
    }
}