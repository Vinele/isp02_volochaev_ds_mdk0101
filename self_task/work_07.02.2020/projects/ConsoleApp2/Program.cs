using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector01 = new Vector(5, 6, 7);
            Vector vector02 = new Vector(9, 19, 5);
            Console.WriteLine(vector01.ToString());
            Console.WriteLine(vector02.ToString());
            Console.WriteLine($"Длинна вектора 1 - {vector01.Lenght(vector01)}");
            Console.WriteLine($"Длинна вектора 2 - {vector02.Lenght(vector02)}");
            Console.WriteLine($"Скалярное произведение - {vector02.ScalarProduct(vector01, vector02)}");
            Console.WriteLine($"Векторное произведение - {vector02.Product(vector01, vector02)}");
            Console.ReadKey();
        }
    }
}
