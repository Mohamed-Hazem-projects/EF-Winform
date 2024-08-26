using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    internal class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        [MaxLength(50)]
        public string? Crs_Name { get; set; }
        public int? Crs_Duration { get; set; }
        public int? Top_Id { get; set; }
        [ForeignKey("Top_Id")]
        public virtual Topic? topic { get; set; }
        public virtual ICollection<Ins_Course> ins_courses { get; set; } = new HashSet<Ins_Course>();
        public virtual ICollection<Stud_Course> stud_courses { get; set; } = new HashSet<Stud_Course>();
    }
}
