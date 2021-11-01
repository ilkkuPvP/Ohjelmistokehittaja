using System;

namespace tehtava5
{
    class Program
    {
        public static int luku;
        static void Main()
        {
            Console.WriteLine("Syötä aloitus numerosi: ");
            luku = int.Parse(Console.ReadLine());
            lukuMuotoValinta();
        }

        static void lukuMuotoValinta()
        {
            Console.WriteLine("");
            Console.WriteLine("Mitä haluat lisätä numeroosi? (Kokonaisluku, Double, Merkkijono)");
            String lukuMuoto = Console.ReadLine();

            switch (lukuMuoto)
            {
                case ("Kokonaisluku"):
                    luku += 1;
                    Console.WriteLine(luku);
                    break;
                case ("Double"):
                    luku *= 2;
                    Console.WriteLine(luku);
                    break;
                case ("Merkkijono"):
                    Console.WriteLine(luku + "*");
                    break;
                default:
                    Console.WriteLine("Valitse (Kokonaisluku, Double, Merkkijono)");
                    break;
            }

            Console.WriteLine("-----");
            Console.WriteLine("Haluatko vielä lisätä jotain muuta? (Kyllä vai Ei)");
            if (Console.ReadLine() == "Kyllä")
            {
                Console.WriteLine("-----");
                lukuMuotoValinta();
            }

            else
            {
                Uusi();
            }
        }

        static void Uusi()
        {
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
                Console.WriteLine("Hei hei sitten!");
            }
        }
    }
}
