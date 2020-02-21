using System;

namespace ConsoleApp1
{
    class ComputerGame
    {
        public string Title { get; set; }
        public string Developments { get; set; }
        public int YearOfReleaze { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return Title + " " + Developments + " " + YearOfReleaze + " " + Genre;
        }

        public ComputerGame(string gameTitle, string gameDevelopments,
                            int gameYearOfReleaze, string gameGenre)
        {
            Title = gameTitle;
            Developments = gameDevelopments;
            YearOfReleaze = gameYearOfReleaze;
            Genre = gameGenre;
        }
    }
}
