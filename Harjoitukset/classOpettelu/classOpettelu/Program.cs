using System;

namespace classOpettelu
{
    class Program
    {
        static double alkuSaldo = 14.46;
        static double uusiSaldo = alkuSaldo;
        static void Main()
        {
            /*
            Console.WriteLine("NY LÄHTEE!!!");
            peruslaskut joulupukki = new peruslaskut();
            int summaJ = joulupukki.Summa(4, 5);
            int erotusJ = joulupukki.Erotus(4, 5);
            double osamaaraJ = joulupukki.Osamaara(4, 5);
            int tuloJ = joulupukki.Tulo(4, 5);

            Console.WriteLine("Lukujen {0} ja {1} summa, erotus, osamäärä ja tulo ovat {2} {3} {4} {5}", 4, 5, summaJ, erotusJ, osamaaraJ, tuloJ);
            //Console.WriteLine("Lukujen summa: " + summaJ + ", erotus: " + erotusJ + ", osamäärä: " + osamaaraJ + ", tulo: " + tuloJ);
            */
            pankkitili Ilmari = new pankkitili("Ilmari", "Lindberg", "1234567890", alkuSaldo);
            Vipu();
        }
        static void Vipu()
        {
            pankkitili Ilmari = new pankkitili("Ilmari", "Lindberg", "1234567890", uusiSaldo);

            Console.WriteLine("Saldosi nyt: " + Ilmari.NaytaSaldo());
            Console.WriteLine("Mitä haluat tehdä? (Saldo, Pano, Otto, En mitään)");
            string teko = Console.ReadLine();

            switch (teko)
            {
                case ("Saldo"):
                    Console.WriteLine("-----");

                    Vipu();
                    break;

                case ("Pano"):

                    Console.WriteLine("-----");
                    Console.WriteLine("Paljonko haluat laittaa rahaa?");
                    uusiSaldo = Ilmari.Pano(double.Parse(Console.ReadLine()));

                    Vipu();
                    break;

                case ("Otto"):
                    Console.WriteLine("-----");
                    Console.WriteLine("Paljonko haluat ottaa rahaa?");
                    uusiSaldo = Ilmari.Otto(double.Parse(Console.ReadLine()));

                    Vipu();
                    break;

                default:
                    Console.WriteLine("-----");
                    Console.WriteLine("Kirjauduttu ulos...");
                    Console.WriteLine("-----");
                    break;

            }
        }
    }
}
