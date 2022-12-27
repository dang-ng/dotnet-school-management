using System;
using System.Data.Entity;
using System.Linq;
using DataAccess;
using Models;

namespace SimpleQueries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var rs = context.Entry(context.Courses).Collection("Students").Query();
            }
            
        }
    }
}