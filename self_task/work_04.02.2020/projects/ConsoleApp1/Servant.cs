using System;

namespace ConsoleApp1
{
    class Servant
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Experience { get; set; }

        public override string ToString()
        {
            return Name + " " + Job + " " + Experience;
        }

        public Servant(string servantName, string servantJob, int servantExperience)
        {
            Name = servantName;
            Job = servantJob;
            Experience = servantExperience;
        }
    }
}
