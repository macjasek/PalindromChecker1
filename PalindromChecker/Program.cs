using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz dowolny ciąg znaków");
            var userText = Console.ReadLine();
            var palindrom = userText.ToCharArray();
            Array.Sort(palindrom);

            if (palindrom.Length % 2 == 0)
            {
                PalindromEven(palindrom,0,palindrom.Length-1);
            }
            else
            {
                PalindromOdd(palindrom,0,palindrom.Length -1);
            }
            
        }

        static void PalindromEven(char[] palindrom, int start, int end)
        {
            //Sprawdzanie palindromu parzystego
            if (start > end)
            {
                Console.WriteLine("Z wprowadzanych znaków można utworzyć palindrom");
            }
            else if (palindrom[start] != palindrom[start+1])
            {
                Console.WriteLine("Z wprowadzanych znaków nie można utworzyć palindromu");
            }
            else
            {
                //Wywołanie rekurencyjne
                PalindromEven(palindrom, start + 2, end);
            }

        }

        static void PalindromOdd(char[] palindrom, int start, int end)
        {
            //Sprawdzanie palindromu nieparzystego
            if (start == end)
            {
                Console.WriteLine("Z wprowadzanych znaków można utworzyć palindrom");
            }
            else if (palindrom[start] != palindrom[start + 1])
            {
                //zabieramy jeden znaczek i traktujemy jak parzysty
                PalindromEven(palindrom, start + 1, end);
            }
            else
            {
                //Wywołanie rekurencyjne
                PalindromOdd(palindrom, start + 2, end);
            }
        }
        
    }
}
