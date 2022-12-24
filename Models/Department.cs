using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Department
    {
        public Department()
        {
            Teachers = new HashSet<Teacher>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Office { get; set; }
        [Required]
        public virtual School School { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}