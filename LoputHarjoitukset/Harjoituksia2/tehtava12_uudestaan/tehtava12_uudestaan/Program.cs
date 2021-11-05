using System;

namespace tehtava12_uudestaan
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna luku (suurempi kuin 10):");
            int lukuA = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");

            if (lukuA > 10)
            {
                for(int z = 1; z <= 11; z++)
                {
                    Console.WriteLine("");

                    for (int x = 1; x <= lukuA; x++)
                    {
                        Console.Write(lukuA + " ");
                    }

                    Console.WriteLine("");

                    for (int y = 1; y <= lukuA; y++)
                    {
                        Console.Write(lukuA);
                    }
                }

            }

            else
            {
                Main();
            }
        }
    }
}
