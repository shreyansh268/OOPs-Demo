namespace ConsoleApp2
{
    public class Student
    {
        public int MarksMaths { get; set; }
        public int MarksScience { get; set; }
        public int AverageMarks => (MarksMaths+ MarksScience)/2;
        public string Name { get; set; }

        public Student(int maths, int science, string name)
        {
            Name = name;
            MarksMaths = maths;
            MarksScience = science;
        }
    }
}