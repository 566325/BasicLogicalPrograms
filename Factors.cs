using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class Factors
    {
        public static void FactorOfNumber()
        {
            int n, i;
            Console.WriteLine("Enter a Number");
            n=Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }

            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
