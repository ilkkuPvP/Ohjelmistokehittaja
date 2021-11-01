using System;

namespace tehtava6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna piste määrä (1-9):");
            int pisteetA = int.Parse(Console.ReadLine());
            int pisteetB = pisteetA;

            switch (pisteetA)
            {
                case (1):
                case (2):
                case (3):
                    pisteetB *= 10;
                    Console.WriteLine("Pisteesi kerrottiin kymmenellä: " + pisteetB);
                    break;
                case (4):
                case (5):
                case (6):
                    pisteetB *= 100;
                    Console.WriteLine("Pisteesi kerrottiin sadalla: " + pisteetB);
                    break;
                case (7):
                case (8):
                case (9):
                    pisteetB *= 1000;
                    Console.WriteLine("Pisteesi kerrottiin tuhannella: " + pisteetB);
                    break;

                default:
                    Console.WriteLine("Virhe. Anna pistemäärä (1-9 väliltä)");
                    break;
            }
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
