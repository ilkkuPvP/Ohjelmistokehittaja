using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjastoProjekti
{
    class Kirjat
    {
        private string kNimi, kTekija, kPituus, kTunnus, kLainattu;

        public Kirjat(string kNimiA, string kTekijaA, string kPituusA, string kTunnusA, string kLainattuA)
        {
            kNimi = "Kirja: " + kNimiA;
            kTekija = "Tekijä: " + kTekijaA;
            kPituus = "Pituus: " + kPituusA;
            kTunnus = "Tunnus: " + kTunnusA;
            kLainattu = kLainattuA;
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
