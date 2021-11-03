using System;
using System.Collections.Generic;
using System.Text;

namespace classOpettelu
{
    class peruslaskut
    {
        int summa;
        int erotus;
        double osamaara;
        int tulo;

        public int Summa(int a, int b)
        {
            return a += b;
        }

        public int Erotus(int a, int b)
        {
            return a -= b;
        }

        public double Osamaara(int a, int b)
        {
            return a /= b;
        }

        public int Tulo(int a, int b)
        {
            return a *= b;
        }


    }
}
