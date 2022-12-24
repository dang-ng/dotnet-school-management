using System.Collections.Generic;

namespace Models
{
    public class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public int Credit { get; set; } = 3;
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}