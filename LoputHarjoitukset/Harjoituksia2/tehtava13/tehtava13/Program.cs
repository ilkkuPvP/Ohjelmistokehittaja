using System;

namespace tehtava13
{
    class Program
    {
        static void Main(string[] args)
        {
            string textIn = Console.ReadLine();
            string textOut;
            Console.WriteLine("-----");
            textOut = textIn.Substring(textIn.Length - 1);
            textOut += textIn.Substring(1, textIn.Length - 2);
            textOut += textIn.Substring(0, 1);
            
            Console.WriteLine(textOut);
        }
    }
}
