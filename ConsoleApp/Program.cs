using System;
using System.Data.Entity;
using System.Linq;
using DataAccess;
using Models;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Hogwarts School of Witchcraft and Wizardry";
            using (var context = new UniversityContext())
            {
                var teachers = context.People.Include("Courses").Include("Department").OfType<Teacher>().ToList();
                Console.WriteLine("### HOGWARTS STAFFS ###");
                foreach (var t in teachers)
                {
                    Console.WriteLine($"{t.FirstName} {t.LastName} {t.Qualification} at {t.Department.Name}");
                    if (t.Courses.Count > 0)
                    {
                        Console.WriteLine("Teaching course:");
                        foreach (var c in t.Courses)
                        {
                            Console.WriteLine($"{c.Name}");
                        }
                    }
                }

                var students = context.People.OfType<Student>().ToList();
                Console.WriteLine("### STUDENTS ###");
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName} {(string.IsNullOrEmpty(s.Group)?"":$"{s.Group}")}");
                }
            }
        }
    }
}