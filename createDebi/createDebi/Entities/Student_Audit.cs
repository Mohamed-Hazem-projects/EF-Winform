using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.Entities
{
    [PrimaryKey(nameof(the_key), nameof(Note))]
    internal class Student_audit
    {
        public int the_key { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Note { get; set; }
        [Column(TypeName = "date")]
        public DateTime The_date { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Server_User_name { get; set; }
    }
}
