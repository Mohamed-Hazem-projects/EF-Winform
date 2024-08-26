using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    internal class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        [MaxLength(50)]
        public string? Dept_Name { get; set; }
        [MaxLength(100)]
        public string? Dept_Desc { get; set; }
        [MaxLength(50)]
        public string? Dept_Location { get; set; }
        public int? Dept_Manager { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Manager_hiredate { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();
    }
}
