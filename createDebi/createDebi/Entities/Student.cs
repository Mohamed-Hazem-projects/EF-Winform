using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace createDebi.Entities
{
    internal class Student
    {
        [Key]
        public int St_Id { get; set; }
        [MaxLength(50)]
        public string? St_Fname { get; set; }
        [MaxLength(10)]
        public string? St_Lname { get; set; }
        [MaxLength(100)]
        public string? St_Address { get; set; }
        public int? St_Age { get; set; }
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public int? St_super { get; set; }

        public virtual ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public virtual Department Department { get; set; }
        [ForeignKey("St_super")]
        public virtual Student Students { get; set; }
    }
}
