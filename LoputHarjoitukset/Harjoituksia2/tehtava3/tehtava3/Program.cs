using System;

namespace tehtava3
{
    class Program
    {
        static void Main()
        {
            static string laske(float luku1, float luku2)
            {
                float summa = luku1 + luku2;
                float erotus = luku1 - luku2;
                float jako = luku1 / luku2;
                float kerto = luku1 * luku2;

                string muunto = String.Format("{0} / {1} / {2} / {3}", summa, erotus, jako, kerto);
                return muunto;
            }

            Console.WriteLine("Anna 1. luku");
            float luku1Annettu = float.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            Console.WriteLine("Anna 2. luku");
            float luku2Annettu = float.Parse(Console.ReadLine());

            Console.WriteLine(laske(luku1Annettu, luku2Annettu));

            /*
            static float laskeErotus()
            {

            }

            static float laskeKerto()
            {

            }

            static float laskeJako()
            {

            }
            */

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
