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
            Kirjat kirja4Oma = new Kirjat("", "", "", "", "Kyllä");
            Kirjat kirja666 = new Kirjat("Kallen hirmuinen nalle", "[#/&}!?{&]", "666", "666", "Ei");
            Teot();


            void Teot()
            {
                ALKU:

                Console.WriteLine("Mitä haluat tehdä kirjastossa? (Selaa, Lainaa, Palauta, Julkaise, Poista tai Poistu)");
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
                        Palauta();
                        goto ALKU;


                    case ("poistu"):
                        Console.Clear();
                        Console.WriteLine("Kiitos, kun kävit!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Tervetuloa uudelleen!");
                        Thread.Sleep(2000);
                        break;

                    case ("julkaise"):
                        Console.Clear();
                        Julkaise();
                        goto ALKU;

                    case ("!palaa"):
                        Selaa();
                        break;

                    case ("poista"):
                        Console.Clear();
                        PoistaJulkaisu();
                        goto ALKU;


                    default:
                        Console.WriteLine("-----");
                        goto ALKU;

                }
            }

            void PoistaJulkaisu()
            {
                Selaa();

                string jKirjaTunnus = kirja4Oma.HaeTunnus().ToString().ToLower();

                POISTOALKU:
                Console.WriteLine("Anna poistettavan julkaisusi tunnus (palaa kirjoittamalla \"!palaa\"):");
                string poistoTunnus = Console.ReadLine().ToLower();
                Console.Clear();
                Selaa();

                if(poistoTunnus == jKirjaTunnus && poistoTunnus != "" && poistoTunnus != "!palaa")
                {
                    kirja4Oma = new Kirjat("", "", "", "", "Kyllä");
                    Console.WriteLine("Julkaisusi on poistettu");
                    Console.WriteLine("-----");
                    Teot();
                }
                else
                {
                    Console.WriteLine("Antamasi tunnus " + "(" + poistoTunnus + ")" + " on väärä tai se ei ole sinun");
                    Console.WriteLine("-----");
                    goto POISTOALKU;

                }
                


            }

            void Julkaise()
            {
                Selaa();

                //kirja4Oma.Julkaisu();
                //string jPalaako = kirja4Oma.Palata(a).ToString().ToLower();

                /*if(kirja4Oma.Palata(kirja4Oma.Julkaisu()) == true)
                {
                    Console.Clear();
                    Teot();
                }*/

                if(kirja4Oma.Julkaisu() == "palattu")
                {
                    Console.Clear();
                    Selaa();
                }

                else
                {


                
                    Console.WriteLine("-----");

                    //Näytä kirja
                    string[] kTaulu4Oma = { kirja4Oma.kirjaNimi(), kirja4Oma.kirjaTekija(), kirja4Oma.kirjaPituus(), kirja4Oma.kirjaTunnus() };

                    foreach (string taulu4Oma in kTaulu4Oma)
                    {
                        Console.WriteLine(taulu4Oma);
                    }

                    Console.WriteLine("-----");
                

                    //Console.Clear();
                    //Selaa();
                }
                
            }

            void Lainaa()
            {
                Selaa();

                string jKirjaTunnus = kirja4Oma.HaeTunnus().ToString().ToLower();

                Console.WriteLine("Anna lainattavan kirjan tunnus (palaa kirjoittamalla \"!palaa\"):");
                string lainaTunnus = Console.ReadLine().ToLower();
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

                    case ("!palaa"):
                        Teot();
                        break;

                    default:
                        break; ;
                }

                if(lainaTunnus == "1" || lainaTunnus == "2" || lainaTunnus == "3" || lainaTunnus == "666")
                {
                    Console.WriteLine("-----");
                    return;
                }
                
                if(lainaTunnus == jKirjaTunnus && lainaTunnus != "" && lainaTunnus != "!palaa")
                {
                    kirja4Oma.Lainaus();
                }

                else
                {
                    Console.WriteLine("Antamasi tunnus on virheellinen " + "(" + "Tunnus: " + lainaTunnus + ")");
                }
                Console.WriteLine("-----");

            }

            void Selaa()
            {
                string[] kTaulu1 = { kirja1.kirjaNimi(), kirja1.kirjaTekija(), kirja1.kirjaPituus(), kirja1.kirjaTunnus() };
                string[] kTaulu2 = { kirja2.kirjaNimi(), kirja2.kirjaTekija(), kirja2.kirjaPituus(), kirja2.kirjaTunnus() };
                string[] kTaulu3 = { kirja3.kirjaNimi(), kirja3.kirjaTekija(), kirja3.kirjaPituus(), kirja3.kirjaTunnus() };
                string[] kTaulu4Oma = { kirja4Oma.kirjaNimi(), kirja4Oma.kirjaTekija(), kirja4Oma.kirjaPituus(), kirja4Oma.kirjaTunnus() };
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
                foreach (string taulu4Oma in kTaulu4Oma)
                {
                    Console.WriteLine(taulu4Oma);
                }

                Console.WriteLine("-----");
            }

            void Palauta()
            {
                string jKirjaTunnus = kirja4Oma.HaeTunnus().ToString().ToLower();

                Selaa();
                Console.WriteLine("Anna palautettavan kirjan tunnus (palaa kirjoittamalla \"!palaa\"):");
                string palautusTunnus = Console.ReadLine();
                Console.Clear();
                Selaa();

                switch (palautusTunnus)
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

                    case ("!palaa"):
                        Teot();
                        break;

                    default:
                        break;
                }

                if (palautusTunnus == "1" || palautusTunnus == "2" || palautusTunnus == "3" || palautusTunnus == "666")
                {
                    Console.WriteLine("-----");
                    return;
                }

                if (palautusTunnus == jKirjaTunnus && palautusTunnus != "" && palautusTunnus != "!palaa")
                {
                    kirja4Oma.Palautus();
                }
                else
                {
                    Console.WriteLine("Antamasi tunnus on virheellinen " + "(" + "Tunnus: " + palautusTunnus + ")");
                }
                Console.WriteLine("-----");
            }
        }

    }
}
