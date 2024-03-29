using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Matematik
    {  
        public int Mutlak(int a)
        {
            if (a >= 0) return a;
            else
            {
                return a * -1;
            }
        }
        public int Karekok(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                if (i * i == a) return i;
                else if (i * i > a) break;
            }
            return -1;
        }

        public int MaxBulma(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= max) max = a[i];
            }
            return max;           
}
        public double Us(double a, double b)
        {
            double sonuc = 1.0;
            for (double i = 0.0; i < b; i++)
            {
                sonuc *= a;
            }
            return sonuc;
        }

        public double Faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Faktoriyel(n - 1);
        }
        public  double Sin(double x)
        {
            //Taylor serisi
            double sonuc = 0;
            int tekrar = 10; 

            for (int i = 0; i < tekrar; i++)
            {
                int ussu = 2 * i + 1;
                double term = Us(-1.0, i) * Us(x, ussu) / Faktoriyel(ussu);
                sonuc += term;
            }

            return sonuc;
        }
        public double Cos(double x)
        {
           
            return Sin(3.14/2-x);
        }

        public double RadyanaCevir(int aci)
        {

            return aci * 3.14 / 180;
        }





    }
}
