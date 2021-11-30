using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kirjastoProjekti
{
    class Kirjat
    {
        private string kNimi, kTekija, kPituus, kTunnus, kLainattu, kTunnusRaaka, kPalaa;

        public Kirjat(string kNimiA, string kTekijaA, string kPituusA, string kTunnusA, string kLainattuA)
        {
            kNimi = "Kirja: " + kNimiA;
            kTekija = "Tekijä: " + kTekijaA;
            kPituus = "Pituus: " + kPituusA;
            kTunnus = "Tunnus: " + kTunnusA;
            kLainattu = kLainattuA;
            kTunnusRaaka = "";
            kPalaa = "";
        }


        public string Julkaisu()
        {
            
            Console.WriteLine("Kerro julkaisemasi kirjan nimi (palaa kirjoittamalla \"!palaa\"):");
            string jkNimi = Console.ReadLine();
            Console.WriteLine("-----");

            if (Palata(jkNimi))
            {
                return kPalaa = "palattu";
                //return;
            }

            Console.WriteLine("Kerro julkaisemasi kirjan tekijä (palaa kirjoittamalla \"!palaa\"):");
            string jkTekija = Console.ReadLine();
            Console.WriteLine("-----");

            if (Palata(jkTekija))
            {
                return kPalaa = "palattu";
                //return;
            }

            Console.WriteLine("Kerro julkaisemasi kirjan sivujen määrä (palaa kirjoittamalla \"!palaa\"):");
            string jkPituus = Console.ReadLine();
            Palata(jkPituus);

            if (Palata(jkPituus))
            {
                return kPalaa = "palattu";
                //return;
            }

        JUTUNNUS:
            Console.WriteLine("-----");
            Console.WriteLine("Anna julkaisemallesi kirjalle tunnus (palaa kirjoittamalla \"!palaa\"):");

            string jkTunnus = Console.ReadLine();
            Console.WriteLine("-----");
            Palata(jkTunnus);

            if (Palata(jkTunnus))
            {
                return kPalaa = "palattu";
                //return;
            }
            /*
            if (jkNimi.ToLower() == "!palaa" || jkTekija.ToLower() == "!palaa" || jkPituus.ToLower() == "!palaa" || jkTunnus.ToLower() == "!palaa")
            {
                kPalaa = "palattu";
                return;
            }
            */
            //else
            //{

            if (jkTunnus == "1" || jkTunnus == "2" || jkTunnus == "3" || jkTunnus == "666")
            {
                Console.WriteLine("Antamasi tunnus on jo käytössä");
                goto JUTUNNUS;
            }

            else
            {
                kLainattu = "Ei";
                //string jkTunnus = "4";
                string jkLainattu = "Ei";

                kNimi = "Kirja: " + jkNimi;
                kTekija = "Tekijä: " + jkTekija;
                kPituus = "Pituus: " + jkPituus;
                kTunnus = "Tunnus: " + jkTunnus;
                kTunnusRaaka = jkTunnus;
                kLainattu = jkLainattu;

                Thread.Sleep(1000);
                Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Kirjaasi julkaistaan.");
                    Thread.Sleep(600);
                    Console.Clear();
                    Console.WriteLine("Kirjaasi julkaistaan..");
                    Thread.Sleep(600);
                    Console.Clear();
                    Console.WriteLine("Kirjaasi julkaistaan...");
                    Thread.Sleep(600);
                    Console.Clear();
                }

                
                Console.Clear();
                Console.WriteLine("Julkaisemasi kirjan tunnus on \"" + jkTunnus + "\" ja se näyttää kirjastossa tältä:");
                return kPalaa = "";
            }

            //}
        }

        public bool Palata(string a)
        {
            if(a == "!palaa")
            {
                //kPalaa = "palattu";
                return true;
            }
            else
            {
                return false;
            }
        }

        public string HaeTunnus()
        {
            if(kTunnusRaaka != "")
            {
                return kTunnusRaaka;
            }
            else
            {
                return kTunnusRaaka = "";
            }
        }

        public void Lainaus()
        {
            
            if (kLainattu == "Ei")
            {
                Console.WriteLine("Lainasit valitsemasi kirjan " + "(" + kTunnus + ")");
                kLainattu = "Kyllä";
            }
            else
            {
                
                Console.WriteLine("Valitsemasi kirja on jo lainattu " + "(" + kTunnus + ")");


            }
            //Console.WriteLine("-----");
        }

        public string Palautus()
        {
            if (kLainattu == "Kyllä")
            {

                Console.WriteLine("Kirjasi on palautettu " + "(" + kTunnus + ")");

                return kLainattu = "Ei";
            }
            else
            {
                Console.WriteLine("Et ole lainannut tätä kirjaa " + "(" + kTunnus + ")");
                return "";
            }
        }

        public string kirjaNimi()
        {

            if (kLainattu == "Ei")
            {
                return kNimi;
            }
            else
            {
                return "";
            }
        }

        public string kirjaTekija()
        {
            if (kLainattu == "Ei")
            {
                return kTekija;
            }
            else
            {
                return "";
            }
        }

        public string kirjaPituus()
        {
            if (kLainattu == "Ei")
            {

                return kPituus;
            }
            else
            {
                return "";
            }
        }

        public string kirjaTunnus()
        {
            if (kLainattu == "Ei")
            {
                return kTunnus;
            }
            else
            {
                return kTunnus;
            }
        }

    }
}
