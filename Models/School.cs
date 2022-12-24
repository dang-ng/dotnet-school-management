using System.Collections.Generic;

namespace Models
{
    public class School
    {
        public School()
        {
            Departments = new HashSet<Department>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}