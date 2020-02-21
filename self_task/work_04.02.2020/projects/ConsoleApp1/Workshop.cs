using System;

namespace ConsoleApp1
{
    class Workshop
    {
        public string StringCipher { get; set; }
        public int NumberOfEmployees { get; set; }

        public override string ToString()
        {
            return StringCipher + " " + NumberOfEmployees;
        }

        public Workshop(string workshopStringCipher, int workshopNumberOfEmployees)
        {
            StringCipher = workshopStringCipher;
            NumberOfEmployees = workshopNumberOfEmployees;
        }
    }
}
