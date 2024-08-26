using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    [PrimaryKey(nameof(Ins_Id), nameof(Crs_Id))]
    internal class Ins_Course
    {
        [ForeignKey("Instructor")]
        public int Ins_Id { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        [MaxLength(50)]
        public string? Evaluation { get; set; }
        public virtual Course course { get; set; }
        public virtual Instructor instructor { get; set; }
    }
}
