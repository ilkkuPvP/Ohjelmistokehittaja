using System;

namespace tehtava2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna 1. numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna 3. numero: ");
            int n3 = int.Parse(Console.ReadLine());

            int minL = Math.Max(n1, n2);
            int maxL = Math.Max(minL, n3);

            Console.WriteLine("Suurin luku: " + maxL);


            Console.WriteLine("Haluatko kokeilla uudestaan? (Kyllä vai Ei)");
            if (Console.ReadLine() == "Kyllä")
            {
                Main();
            }

            else
            {
                Console.WriteLine("Hei hei sitten!");
            }
        }

    }
}
