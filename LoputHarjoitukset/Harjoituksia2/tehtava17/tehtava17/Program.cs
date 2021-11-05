using System;

namespace tehtava17
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i += 1)
            {

                //Tulostaa vain 3 jaolliset luvut, eli ei 2 jaollisia!
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
