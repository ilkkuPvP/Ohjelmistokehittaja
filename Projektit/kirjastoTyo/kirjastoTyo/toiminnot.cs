using System;
using System.Collections.Generic;
using System.Text;

namespace kirjastoTyo
{
    public class Toiminnot
    {


        
        public string Lainaa(string lainattava)
        {
            Kirjat kirja1 = new Kirjat();
            kirja1.kNimi = "Pekka Puukasa ja Joulupuu";
            kirja1.kTekija = "Pekka Luukasa";
            kirja1.kPituus = "86";
            kirja1.kTunnus = "1";
            string k1Tunnus = kirja1.kTunnus;

            Kirjat kirja2 = new Kirjat();
            kirja2.kNimi = "Peruna Sankari: Vihannesten hyökkäys";
            kirja2.kTekija = "Ilmari Lindberg";
            kirja2.kPituus = "193";
            kirja2.kTunnus = "2";
            string k2Tunnus = kirja2.kTunnus;

            Kirjat kirja3 = new Kirjat();
            kirja3.kNimi = "Timo: Uusi Seikkailu";
            kirja3.kTekija = "Timon kaveri";
            kirja3.kPituus = "265";
            kirja3.kTunnus = "3";
            string k3Tunnus = kirja3.kTunnus;

            Kirjat kirja666 = new Kirjat();
            kirja666.kNimi = "Kallen hirmuinen nalle";
            kirja666.kTekija = "[#/&}!?{&]";
            kirja666.kPituus = "666";
            kirja666.kTunnus = "666";
            string k666Tunnus = kirja666.kTunnus;

            if(lainattava == k1Tunnus)
            {
                Console.Clear();
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
            }
            return lainattava;

        }
        
    }


}
