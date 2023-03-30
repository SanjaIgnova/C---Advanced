using SEDC.Class02.Exercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class02.Exercise.Class
{
    public class Students : User, IStudet
    {

        List<int> Grades { get; set; }

        public Students(int id, string name, string username, string password, List<int> grades) : base(id, name, username, password)
        {
            Grades = grades;
        }
        public override void PrintUser()
        {
        
         Console.WriteLine($"ID: {Id}, Name: {Name} and Username: {Username}");
           
        }

        public void PrintGrades()
        {
            Console.WriteLine("Grades:");
            foreach (var grades in Grades)
            {
                Console.WriteLine(grades);
            }
        }
    }
}
