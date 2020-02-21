using System;

namespace ConsoleApp1
{
    class Banknote
    {
        public string SeriesAndNumber { get; set; }
        public int Par { get; set; }
        public string ParInWords { get; set; }

        public override string ToString()
        {
            return SeriesAndNumber + " " + Par + " " + ParInWords;
        }

        public Banknote(string banknoteSeriesAndNumber, int banknotePar, string banknoteParInWords)
        {
            SeriesAndNumber = banknoteSeriesAndNumber;
            Par = banknotePar;
            ParInWords = banknoteParInWords;
        }
    }
}
