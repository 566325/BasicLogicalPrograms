using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class EvenOrOdd
    {
        public static void CheckEvenOrOdd()
        {
            
            Console.WriteLine("Enter the Value ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine(i + "is Even");
            }
            else
            {
                Console.WriteLine(i + " is Odd");
            }
        }
    }
    
}
