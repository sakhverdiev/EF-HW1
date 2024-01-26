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
    public  class GroupAndLecture
    {
        [Key] 
        public int Id { get; set; }
        [Required, NotNull]
        [ForeignKey(nameof(Group))]
        public int GroupId{ get; set; }
        public Group? Group { get; set; }

        [Required, NotNull] 
        [ForeignKey(nameof(Lecture))]
        public int LectureId{ get; set; }
        public Lecture? Lecture { get; set; }




    }
}
