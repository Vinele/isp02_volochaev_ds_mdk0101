using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("ivan", "isp", "male");
            Servant servant01 = new Servant("ivan", "soldier", 15);
            Workshop workshop01 = new Workshop("AA012", 27);
            Book book01 = new Book("Parry Hotter", new string[] { "ivanov", "petrov" }, 175);
            Offset offset01 = new Offset("ivanov ivan ivanovich", "petrov petr petrovich", 27, 5);
            Address address01 = new Address(1589, "Moscow", "Mira", 5, 18);
            Product product01 = new Product("Papper", 543, 123, 10);
            StudyGroup studyGroup01 = new StudyGroup("2.18", 19, 1999, "isp2");
            Banknote banknote01 = new Banknote("AB089", 10, "ten");
            ComputerGame computerGame01 = new ComputerGame("gameOfTheBestOrNo", "SGINC", 1895, "platformer");

            Console.WriteLine(student01);
            Console.WriteLine(servant01);
            Console.WriteLine(workshop01);
            Console.WriteLine(book01);
            Console.WriteLine(offset01);
            Console.WriteLine(address01);
            Console.WriteLine(product01);
            Console.WriteLine(studyGroup01);
            Console.WriteLine(banknote01);
            Console.WriteLine(computerGame01);

            Console.ReadKey();
        }
    }
}
