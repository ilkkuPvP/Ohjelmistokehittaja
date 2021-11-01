using System;

namespace tehtava3
{
    class Program
    {
        static void Main()
        {
            static float laske()
            {
                float summa = luku1 + luku2;
                float erotus = luku1 - luku2;
            }

            static float laskeErotus()
            {

            }

            static float laskeKerto()
            {

            }

            static float laskeJako()
            {

            }






            Console.WriteLine("Anna 1. luku:");
            float luku1A = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. luku:");
            float luku2A = float.Parse(Console.ReadLine());

            Console.WriteLine("Summa: " + (luku1A + luku2A));
            Console.WriteLine("Summa: " + (luku1A + luku2A));
            Console.WriteLine("Summa: " + (luku1A + luku2A));
            Console.WriteLine("Summa: " + (luku1A + luku2A));





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
