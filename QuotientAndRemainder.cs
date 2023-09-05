using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class QuotientAndRemainder
    {
        public static void CheckQuotientAndRemainder()
        {
            int Dividend = 70, Divisor = 8;

            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", Dividend, Divisor);
            Console.WriteLine("Quotient = " + Quotient);
            Console.WriteLine("Remainder = " + Remainder);
            Console.ReadLine();

        }
    }
}
