using System;

namespace tehtava2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna Celsius-asteet:");
            float celsius = float.Parse(Console.ReadLine());
            float fah = celsius * 1.8f + 32;
            Console.WriteLine("-----");
            Console.WriteLine("Fahrenheitteina: " + fah);











            //Kysyy haluatko aloittaa ja yrittää uudestaan
            Console.WriteLine("-----");
            Console.WriteLine("Haluatko kokeilla uudestaan? (Kyllä vai Ei)");
            if (Console.ReadLine() == "Kyllä")
            {
                Console.WriteLine("-----");
                Main();
            }

            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("Hei hei sitten!");
            }
        }
    }
}
