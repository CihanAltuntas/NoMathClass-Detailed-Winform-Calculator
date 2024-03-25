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
                return a + (-2 * a);
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
        public int Sinus(int a)
        {

            return -1;
        }



    }
}
