using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    [PrimaryKey(nameof(Crs_Id), nameof(St_Id))]
    internal class Stud_Course
    {
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        [ForeignKey("Student")]
        public int St_Id { get; set; }
        public int? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
