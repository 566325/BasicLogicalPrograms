using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class SwapNumbers
    {
        public static void SwapTwoNumbers()
        {
            int a = 20;
            int b = 40,temp;

            Console.WriteLine("before Swap a=" + a+"b="+ b);
            temp = a;
            a = b;
            b = temp;
           

            Console.WriteLine("After Swap a=" + a+"b="+ b);


        }
    }
}
