using System;

namespace tehtava4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna 1. numero: ");
            int n1 = int.Parse(Console.ReadLine());//8
            Console.WriteLine("Anna 2. numero: ");
            int n2 = int.Parse(Console.ReadLine());//5
            Console.WriteLine("Anna 3. numero: ");
            int n3 = int.Parse(Console.ReadLine());//2
            Console.WriteLine("Anna 4. numero: ");
            int n4 = int.Parse(Console.ReadLine());//7
            Console.WriteLine("Anna 5. numero: ");
            int n5 = int.Parse(Console.ReadLine());//6

            int l1 = Math.Max(n1, n2);//8,5  8
            int l2 = Math.Max(l1, n3);//8,2  8
            int l3 = Math.Max(l2, n4);//8,7  8
            int l4 = Math.Max(l3, n5);//8,6  8


            Console.WriteLine("Suurin luku: " + l4);



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
                Console.WriteLine("Hei hei sitten!");
            }
        }
    }
}
