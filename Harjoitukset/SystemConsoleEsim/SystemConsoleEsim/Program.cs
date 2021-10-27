using System;

namespace SystemConsoleEsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hei ");
            Console.WriteLine("kaikille!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Hyvää päivää, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
// The example displays output similar to the following:
//       Hyvää päivää!
//       Enter your name: James
//       Good day, James!