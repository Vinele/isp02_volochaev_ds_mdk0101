using System;

namespace ConsoleApp1
{
    class StudyGroup
    {
        public string Cipher { get; set; }
        public int NumberOfStudents { get; set; }
        public int YearOfFormation { get; set; }
        public string Speciality { get; set; }

        public override string ToString()
        {
            return Cipher + " " + NumberOfStudents + " " + YearOfFormation + " " + Speciality;
        }

        public StudyGroup(string studyGroupCipher, int studyGroupNumberOfStudents,
                          int studyGroupYearOfFormation, string studyGroupSpeciality)
        {
            Cipher = studyGroupCipher;
            NumberOfStudents = studyGroupNumberOfStudents;
            YearOfFormation = studyGroupYearOfFormation;
            Speciality = studyGroupSpeciality;
        }
    }
}
