using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kirjastoProjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa kirjastoon!");
            Thread.Sleep(2000);
            Console.WriteLine("");

            //Kirja, Tekijä, Sivut, Tunnus, Varattu
            Kirjat kirja1 = new Kirjat("Pekka Puukasa ja Joulupuu", "Pekka Luukasa", "86", "1", "Ei");
            Kirjat kirja2 = new Kirjat("Peruna Sankari: Vihannesten hyökkäys", "Ilmari Lindberg", "193", "2", "Ei");
            Kirjat kirja3 = new Kirjat("Timo: Uusi Seikkailu", "Timon kaveri", "265", "3", "Ei");
            Kirjat kirja666 = new Kirjat("Kallen hirmuinen nalle", "[#/&}!?{&]", "666", "666", "Ei");
            Teot();


            void Teot()
            {
                ALKU:

                Console.WriteLine("Mitä haluat tehdä kirjastossa? (Selaa, Lainaa, Palauta tai Poistu)");
                string teko = Console.ReadLine();

                switch (teko.ToLower())
                {
                    case ("selaa"):
                        Console.Clear();
                        Selaa();
                        goto ALKU;


                    case ("lainaa"):
                        Console.Clear();
                        Lainaa();
                        goto ALKU;


                    case ("palauta"):
                        Console.Clear();
                        Selaa();
                        Palauta();
                        break;


                    case ("poistu"):
                        Console.Clear();
                        Console.WriteLine("Kiitos, kun kävit!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Tervetuloa uudelleen!");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("-----");
                        goto ALKU;

                }
            }

            void Lainaa()
            {
                Selaa();

                Console.WriteLine("Mitä haluat lainata? (Anna haluamasi kirjan tunnus)");
                string lainaTunnus = Console.ReadLine();
                Console.Clear();
                Selaa();

                switch (lainaTunnus)
                {
                    case ("1"):
                        kirja1.Lainaus();
                        break;

                    case ("2"):
                        kirja2.Lainaus();
                        break;

                    case ("3"):
                        kirja3.Lainaus();
                        break;

                    case ("666"):
                        kirja666.Lainaus();
                        break;

                    default:
                        Console.WriteLine("Antamasi tunnus on virheellinen " + "(" + "Tunnus: " + lainaTunnus + ")");
                        break;
                }
                Console.WriteLine("-----");

            }

            void Selaa()
            {
                string[] kTaulu1 = { kirja1.kirjaNimi(), kirja1.kirjaTekija(), kirja1.kirjaPituus(), kirja1.kirjaTunnus() };
                string[] kTaulu2 = { kirja2.kirjaNimi(), kirja2.kirjaTekija(), kirja2.kirjaPituus(), kirja2.kirjaTunnus() };
                string[] kTaulu3 = { kirja3.kirjaNimi(), kirja3.kirjaTekija(), kirja3.kirjaPituus(), kirja3.kirjaTunnus() };
                string[] kTaulu666 = { kirja666.kirjaNimi(), kirja666.kirjaTekija(), kirja666.kirjaPituus(), kirja666.kirjaTunnus() };

                Console.WriteLine("-----");
                foreach (string taulu1 in kTaulu1)
                {
                    Console.WriteLine(taulu1);
                }
                Console.WriteLine("-----");
                foreach (string taulu2 in kTaulu2)
                {
                    Console.WriteLine(taulu2);
                }
                Console.WriteLine("-----");
                foreach (string taulu3 in kTaulu3)
                {
                    Console.WriteLine(taulu3);
                }
                Console.WriteLine("-----");
                foreach (string taulu666 in kTaulu666)
                {
                    Console.WriteLine(taulu666);
                }
                Console.WriteLine("-----");
            }

            void Palauta()
            {
                Console.WriteLine("Mitä haluat palauttaa? (Anna kirjasi tunnus)");
                string tunnus = Console.ReadLine();
                Console.Clear();
                Selaa();

                switch (tunnus)
                {
                    case ("1"):
                        kirja1.Palautus();
                        break;
                    case ("2"):
                        kirja2.Palautus();
                        break;
                    case ("3"):
                        kirja3.Palautus();
                        break;
                    case ("666"):
                        kirja666.Palautus();
                        break;

                    default:
                        Console.WriteLine("Antamasi tunnus on virheellinen");
                        break;
                }
                Console.WriteLine("-----");
                Teot();
            }
        }

    }
}
