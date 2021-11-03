using System;
using System.Collections.Generic;
using System.Text;

namespace classOpettelu
{
    class pankkitili
    {
        string tilinumero;
        double saldo;
        string etunimi;
        string sukunimi;

        public pankkitili(string eNimi, string Snimi, string tNum, double sld)
        {
            etunimi = eNimi;
            sukunimi = Snimi;
            tilinumero = tNum;
            saldo = sld;
        }

        public double NaytaSaldo()
        {
            return saldo;
        }

        public double Pano(double rahaa)
        {
            saldo += rahaa;
            return saldo;
        }

        public double Otto(double rahaa)
        {
            if(rahaa > saldo)
            {
                Console.WriteLine("ERROR: Tililläsi ei ole tarpeeksi rahaa");
            }
            else
            {
                saldo -= rahaa;
                NaytaSaldo();
            }
            return saldo;
        }
    }
}
