using System;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public readonly string Gender;

        public override string ToString()
        {
            return Name + " " + Course + " " + Gender;
        }

        public Student( string studentName, string studentCourse, string studentGender)
        {
            Name = studentName;
            Course = studentCourse;
            Gender = studentGender;
        }
    }
}
