using System;
using System.Linq; //Käytän tätä

namespace tehtava15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string lause = Console.ReadLine(); //Pyytää lausetta
            string[] lauseenSanat = lause.Split(" "); //Jakaa lauseen välilyöntejen kohdalta

            //Järjestää sanat suurimmasta pienimpään ja valitsee niistä ensimmäisen, eli pisimmän
            string pisinSana = lauseenSanat.OrderByDescending(x => x.Length).First();

            //Tulostaa vastauksen
            Console.WriteLine("-----");
            Console.WriteLine(pisinSana);

        }
    }
}
