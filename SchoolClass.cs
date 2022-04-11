using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SchoolClass
    {
        public List<Student> Students { get; set; }
        public SchoolClass()
        {

        }

        public List<string> GetToppers()
        {   
            Console.WriteLine("Fetch toppers");
            var toppers = new List<String>();
            Students.Sort(delegate(Student A, Student B)
            {
                return A.AverageMarks.CompareTo(B.AverageMarks);
            });

            for(int i = Students.Count - 1; i > Students.Count - 3; i--) 
            {
                toppers.Add(Students[i].Name);
            }
            return toppers;
        }
    }
}
