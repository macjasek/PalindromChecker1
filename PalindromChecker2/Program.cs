using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromChecker2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz dowolny ciąg znaków");
            var userText = Console.ReadLine();
            var palindrom = userText.ToCharArray();
            Array.Sort(palindrom);
            bool isPalindrom = true;
            bool solitary = false;

            if (palindrom.Length % 2 == 0)
            {
                for (int i = 0; i < palindrom.Length; i += 2)
                {
                    if (palindrom[i] != palindrom[i+1])
                    {
                        isPalindrom = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < palindrom.Length-1; i +=2)
                {
                    if (solitary == false && (palindrom[i] != palindrom[i+1]))
                    {
                        i++;
                        solitary = true;
                    }

                    if (solitary == true && palindrom[i] != palindrom[i + 1])
                    {
                        isPalindrom = false;
                    }
                }

            }

            if (isPalindrom )
            {
                Console.WriteLine("Z wprowadzanych znaków można utworzyć palindrom");
            }
            else
            {
                Console.WriteLine("Z wprowadzanych znaków nie można utworzyć palindromu");
            }
        }
    }
}
