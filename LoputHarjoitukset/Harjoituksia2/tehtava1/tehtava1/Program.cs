using System;

namespace tehtava1
{
    class Program
    {
        static void Main()
        {
            static int laskeYhteen(int luku1, int luku2)
            {
                return (luku1 + luku2);
            }
            int num1, num2, sum;
            Console.WriteLine("Anna 1. luku:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Anna 2. luku:");
            num2 = int.Parse(Console.ReadLine());
            sum = laskeYhteen(num1, num2);
            Console.WriteLine("");
            Console.WriteLine("Antamiesi lukujen summa on: " + sum);





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
