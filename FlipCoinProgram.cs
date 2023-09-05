using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class FlipCoinProgram
    {
        public static void FlipCoin()
        {
            int Head=0,Tail=0;
            Random Flip= new Random();
            int CheckCoin= Flip.Next(0,1);
            if(CheckCoin== Head)
            {
                Console.WriteLine("it is Head");

            }
            else if(CheckCoin==Tail) 
            {
                Console.WriteLine("it Is Tail");
            }
            else
            {
                Console.WriteLine("Tail or Head");
            }



        }
    }
}
