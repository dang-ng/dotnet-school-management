using System.Data.Entity;
using Models;

namespace DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("name=UniversityContext"){}
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}