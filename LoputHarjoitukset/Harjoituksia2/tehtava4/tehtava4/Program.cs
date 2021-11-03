using System;

namespace tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {

            static int laskeJaannos(int a, int b)
            {
                return a % b;
            }

            Console.WriteLine("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            Console.WriteLine("Anna 1. luku: ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("-----");
            Console.WriteLine(laskeJaannos(luku1, luku2));


        }
    }
}
