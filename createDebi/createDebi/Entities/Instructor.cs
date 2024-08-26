using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    internal class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        [MaxLength(50)]
        public string? Ins_Name { get; set; }
        [MaxLength(50)]
        public string? Ins_Degree { get; set; }
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
        public int? Dept_Id { get; set; }
        public virtual ICollection<Ins_Course> Ins_Courses { get; set; } = new HashSet<Ins_Course>();
        public virtual Department? Department { get; set; }
        public virtual ICollection<Department> departments { get; set; }
    }
    internal class InstructorComparer : IEqualityComparer<Instructor>
    {

        public bool Equals(Instructor? x, Instructor? y)
        {
            return x?.Ins_Name == y?.Ins_Name && x?.Salary == y?.Salary;
        }

        public int GetHashCode(Instructor? obj)
        {
            return base.GetHashCode();
        }
    }
}
