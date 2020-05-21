using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, k, q, z;
            Console.Write("Введіть число: ");
            m = Convert.ToInt32(Console.ReadLine());
            k = m % 10;
            m = m / 10;
            z = m % 10;
            q = m / 10;
            Console.WriteLine($"Цифра №1: {q}   ");
            m %= 10;
            Console.WriteLine($"Цифра №3: { k}  ");

        }
    }
}
