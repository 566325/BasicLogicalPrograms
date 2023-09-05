using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class LargeestNumber
    {
        public static void CheckLargeestNumber()
        {
            int N1 =32, N2=51, N3=76;
            if (N1 > N2)
            {
                if (N1 > N3)
                {
                    Console.WriteLine("Number N1 is largest number");
                }
                else
                {
                    Console.WriteLine("Number N3 is largest number");
                }
            }
            else if (N2 > N3) 
            {
                Console.WriteLine("Number N2 is largest number");

            }
            else
            {
                Console.WriteLine("Number N3 is largest number");
            }
            
        }
    }
}
