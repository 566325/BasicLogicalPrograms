using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class PowerOfTwo
    {
        public static void CheckPowerOfTwo()
        {
            int Number, i;
            Console.WriteLine(" Enter a Number");
            Number=Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < Number; i++)
            {
                Console.WriteLine("Power of 2 " +i +"is :" +(Math.Pow(2,i)));
            }

        }
    }
}
