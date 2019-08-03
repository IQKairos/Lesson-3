using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Task1Task2
{
    class Task2
    {
        static void ArifmeticMult(int n, int a1, int t, int mult)
        {
            if (n > 0)
            {
                int an = a1 + (n - 1) * t;
                mult *= an;
                ArifmeticMult(n - 1, a1, t, mult);
            }
            else
            {
                Console.WriteLine(mult);
            }
        }
        static void geometricMult(int gn, int ga1, int alim, int gmult)
        {
            if (alim >= ga1)
            {
                Console.WriteLine(gmult);
            }
            else
            {
                gmult *= ga1;

                geometricMult(gn, ga1 / gn, alim, gmult);

            }
        }
        static void Main(string[] args)
        {
            int n = 5, a1 = 1, t = 1;
            int mult = 1;
            ArifmeticMult(n, a1, t, mult);
            int gn = 2, ga1 = 8, alim = 2, gmult = 1;
            geometricMult(gn, ga1, alim, gmult);
        }
    }
}
