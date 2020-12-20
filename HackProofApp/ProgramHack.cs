using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackProofApp
{
    class ProgramHack
    {
        private static string superTajneHeslo = "StastneAVesele";

        static void Main(string[] args)
        {

            Console.Write("Zadajte heslo: ");
            char c = '\0';
            string input = string.Empty;
            do
            {
                c = Console.ReadKey(true).KeyChar;
                if (char.IsLetterOrDigit(c))
                {
                    Console.Write("*");
                    input += c;
                }
                else break;
            } while (true);
            Console.WriteLine();

            if (!comparePasswords(superTajneHeslo, input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Access denied!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Access granted!");
            }
            Console.ResetColor();

        }

        static bool comparePasswords(string pass1, string pass2)
        {
            return pass1 == pass2;
        }
    }
}
