using SEDC.Class02.Exercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class02.Exercise.Class
{
    public class Teacher : User, ITeacher
    {
        List<string> Subject { get; set; }
        public Teacher(int id, string name, string username, string password, List<string> subject) : base(id, name, username, password)
        {
            Subject = subject;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name} and Username: {Username}");
        }

        public void PrintSubject()
        {
            Console.WriteLine("Subject:");
            foreach (var subject in Subject)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
