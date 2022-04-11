using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new School();

            var classSix = new SchoolClass();
            var classSixStudents = new List<Student>();
            classSixStudents.Add(new Student(30, 40, "Dan"));
            classSixStudents.Add(new Student(40, 40, "Pan"));
            classSixStudents.Add(new Student(30, 50, "Sam"));
            classSix.Students = classSixStudents;
            mySchool.GetToppersOfClass(classSix);

            Console.WriteLine("-------------");
            var classSeven = new SchoolClass();
            var classSevenStudents = new List<Student>();
            classSevenStudents.Add(new Student(10, 30, "Gara"));
            classSevenStudents.Add(new Student(30, 60, "Naruto"));
            classSevenStudents.Add(new Student(60, 60, "Tenten"));
            classSevenStudents.Add(new Student(40, 30, "RockLee"));
            classSeven.Students = classSevenStudents;
            mySchool.GetToppersOfClass(classSeven);
        }
    }
}
