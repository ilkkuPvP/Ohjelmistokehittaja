using System;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna jokin numero:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna vielä jokin toinen numero:");
            int y = int.Parse(Console.ReadLine());

            int numS = Math.Max(x, y);
            int numP = Math.Min(x, y);

            Console.WriteLine("Suuruusjärjestyksessä: " + numP + ", " + numS);

            Console.WriteLine("Haluatko kokeilla uudestaan? (Kyllä tai Ei)");

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
