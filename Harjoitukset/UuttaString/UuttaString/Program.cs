using System;

namespace UuttaString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on nimesi?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei, " + nimi);
            Console.WriteLine("Oletko Datanomi? (Kyllä vai Ei)");

            if ((Console.ReadLine() == "Kyllä") || (Console.ReadLine() == "kyllä")) {

                Console.WriteLine("Hienoa! Kunnon koodari!");
            }

            else if ((Console.ReadLine() == "Ei") || (Console.ReadLine() == "ei")) {
                
                Console.WriteLine("Voi harmi :(");
            }
        }
    }
}
