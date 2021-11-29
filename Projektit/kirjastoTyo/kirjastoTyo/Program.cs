using System;
using System.Threading;

namespace kirjastoTyo
{
    class Program
    {
        static void Main()
        {
            /*
            Kirjat kirja1 = new Kirjat("Pekka Puukasa ja Joulupuu", "Pekka Luukasa", "86", "1");
            Kirjat kirja2 = new Kirjat("Peruna Sankari: Vihannesten hyökkäys","Ilmari Lindberg","193","2");
            Kirjat kirja3 = new Kirjat("Timo: Uusi Seikkailu","Timon kaveri","265","3");
            Kirjat kirja4 = new Kirjat("Kallen hirmuinen nalle","[#/&}!?{&]","666","666");
            */
            Toiminnot toiminnot = new Toiminnot();


            
            //Kirjojen teko
            Kirjat kirja1 = new Kirjat();
            kirja1.kNimi = "Pekka Puukasa ja Joulupuu";
            kirja1.kTekija = "Pekka Luukasa";
            kirja1.kPituus = "86";
            kirja1.kTunnus = "1";
            kirja1.kLainattu = "Ei";
            string k1Tunnus = kirja1.kTunnus;

            Kirjat kirja2 = new Kirjat();
            kirja2.kNimi = "Peruna Sankari: Vihannesten hyökkäys";
            kirja2.kTekija = "Ilmari Lindberg";
            kirja2.kPituus = "193";
            kirja2.kTunnus = "2";
            kirja2.kLainattu = "Ei";
            string k2Tunnus = kirja2.kTunnus;

            Kirjat kirja3 = new Kirjat();
            kirja3.kNimi = "Timo: Uusi Seikkailu";
            kirja3.kTekija = "Timon kaveri";
            kirja3.kPituus = "265";
            kirja3.kTunnus = "3";
            kirja3.kLainattu = "Ei";
            string k3Tunnus = kirja3.kTunnus;

            Kirjat kirja666 = new Kirjat();
            kirja666.kNimi = "Kallen hirmuinen nalle";
            kirja666.kTekija = "[#/&}!?{&]";
            kirja666.kPituus = "666";
            kirja666.kTunnus = "666";
            kirja666.kLainattu = "Ei";
            string k666Tunnus = kirja666.kTunnus;
            
            Console.WriteLine("Tervetuloa kirjastoon!");
            Thread.Sleep(2500);
            Console.WriteLine("");
            Console.WriteLine("Mitä haluat tehdä kirjastossa? (Selaa, Lainaa, Palauta tai Poistu)");
            string teko = Console.ReadLine();

            switch (teko.ToLower())
            {
                case ("selaa"):

                    Console.Clear();
                    Console.WriteLine("-----");
                    Console.WriteLine("Kirja: " + kirja1.kNimi);
                    Console.WriteLine("Tekijä: " + kirja1.kTekija);
                    Console.WriteLine("Sivut: " + kirja1.kPituus);
                    Console.WriteLine("Tunnus: " + kirja1.kTunnus);
                    Console.WriteLine("-----");
                    Console.WriteLine("Kirja: " + kirja2.kNimi);
                    Console.WriteLine("Tekijä: " + kirja2.kTekija);
                    Console.WriteLine("Sivut: " + kirja2.kPituus);
                    Console.WriteLine("Tunnus: " + kirja2.kTunnus);
                    Console.WriteLine("-----");
                    Console.WriteLine("Kirja: " + kirja3.kNimi);
                    Console.WriteLine("Tekijä: " + kirja3.kTekija);
                    Console.WriteLine("Sivut: " + kirja3.kPituus);
                    Console.WriteLine("Tunnus: " + kirja3.kTunnus);
                    Console.WriteLine("-----");
                    Console.WriteLine("Kirja: " + kirja666.kNimi);
                    Console.WriteLine("Tekijä: " + kirja666.kTekija);
                    Console.WriteLine("Sivut: " + kirja666.kPituus);
                    Console.WriteLine("Tunnus: " + kirja666.kTunnus);
                    Console.WriteLine("-----");
                    Console.WriteLine("");

                    Main();
                    break;

                case ("lainaa"):
                    Console.WriteLine("Mitä haluat lainata? (Anna haluamasi kirjan tunnus)");
                    string lainaTunnus = Console.ReadLine();
                    toiminnot.Lainaa(lainaTunnus);
                    Main();
                    
                    break;

                case ("palauta"):

                    break;

                case ("poistu"):
                    Console.Clear();
                    Console.WriteLine("Tervetuloa uudelleen!");
                    break;

                default:
                    Main();
                    break;

            }

        }
    }
}
