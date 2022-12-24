using System;

namespace Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; }
    }
}