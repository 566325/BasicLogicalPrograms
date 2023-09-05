using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalPrograms
{
    internal class Alphabet
    {
        public static void AlphabetIsConsonanttOrVowel()
        {
            Char Ch;
            Console.WriteLine("Enter a Alphabet Number");
            Ch = Convert.ToChar(Console.ReadLine());
            
                switch (Ch)
                {
                    case 'a':
                        {
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        }
                    case 'i':
                        {
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        }
                    case 'o':
                        {
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        }
                    case 'u':
                        {
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        }
                    case 'e':
                        {
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("The Alphabet is Consonant");
                            break;
                        }
                }
                Console.ReadKey();

            


        }

    }    
    
}
