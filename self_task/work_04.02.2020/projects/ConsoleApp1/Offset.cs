using System;

namespace ConsoleApp1
{
    class Offset
    {
        public string FullNameStudent { get; set; }
        public string FullNameTeacher { get; set; }
        public int Date { get; set; }
        public int Assessment { get; set; }

        public override string ToString()
        {
            return FullNameStudent + " " + FullNameTeacher + " " + Date + " " + Assessment;
        }

        public Offset(string offsetFullNameStudent, string offsetFullNameTeacher,
                      int offsetDate, int offsetAssessment)
        {
            FullNameStudent = offsetFullNameStudent;
            FullNameTeacher = offsetFullNameTeacher;
            Date = offsetDate;
            Assessment = offsetAssessment;
        }
    }
}
