using System;

namespace tehtava14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 1. luku (+ tai -):");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. luku (+ tai -):");
            int luku2 = int.Parse(Console.ReadLine());

            if (luku1 < 0 && luku2 < 0)
            {
                Console.WriteLine("-----");
                Console.WriteLine("Molemmat ovat negatiivisia");
            }

            else if (luku1 > 0 && luku2 > 0)
            {
                Console.WriteLine("-----");
                Console.WriteLine("Molemmat ovat positiivisia");
            }

            else if (luku1 == 0 || luku2 == 0)
            {
                Console.WriteLine("-----");
                Console.WriteLine("Anna kaksi kokonaislukua, joista kumpikaan ei ole nolla (0)");
            }

            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
            }
        }
    }
}
