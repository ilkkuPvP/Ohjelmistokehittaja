using System;

namespace tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna jokin kokonaisluku (1-10):");
            int lukuA = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");

            for (int kerroin = 0; kerroin <= 10; kerroin += 1)
            {
                Console.WriteLine(lukuA + " * " + kerroin + " on " + (lukuA * kerroin));
                Console.WriteLine("-----");
            }

        }
    }
}
