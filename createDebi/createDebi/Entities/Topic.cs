using System.ComponentModel.DataAnnotations;

namespace createDebi.Entities
{
    internal class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        [MaxLength(50)]
        public string? Top_Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
    internal class TopicComparer : IEqualityComparer<Topic>
    {

        public bool Equals(Topic? x, Topic? y)
        {
            return x?.Top_Name == y?.Top_Name;
        }

        public int GetHashCode(Topic? obj)
        {
            return base.GetHashCode();
        }
    }
}
