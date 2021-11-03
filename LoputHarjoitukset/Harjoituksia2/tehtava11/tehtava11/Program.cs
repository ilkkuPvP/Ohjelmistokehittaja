using System;

namespace tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            Console.WriteLine("-----");
            Console.WriteLine(ika + " - näytät ikäistäsi nuoremmalta");
        }
    }
}
