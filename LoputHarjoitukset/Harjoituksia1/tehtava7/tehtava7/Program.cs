using System;

namespace tehtava7
{
    class Program
    {
        static void Main()
        {

            // --- KESKEN KESKEN KESKEN KESKEN KESKEN ---

            string lukuKer;
            string lukuLop;
            Console.WriteLine("Anna luku (0-999):");
            int luku = int.Parse(Console.ReadLine());
            //string lukuNum = Console.ReadLine();
            //Array lukuArr = lukuNum.ToCharArray();
            //Console.WriteLine(lukuArr.length);

            if (luku < 10 && luku >= 0)
            {
                lukuKer = "";
            }

            else if (luku = 10)
            {
                lukuLop = "Kymmenen";
            }

            else if (luku > 10 && luku < 100)
            {
                lukuKer = "kymmentä";
            }

            else if (luku = 100)
            {
                lukuLop = "Sata";
            }

            else if (luku > 100 && luku <1000)
            {
                lukuKer = "sataa";
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
