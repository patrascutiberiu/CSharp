using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test=true;
            string text;

            do
            {
                Console.WriteLine("Ecrivez une phrase avec un point : ");
                text = Console.ReadLine();
            } while (text[text.Length-1] != '.');

            text = text.ToUpper();
            text = text.Replace(" ", "");
            text = text.Replace('é', 'e');
            text = text.Replace('è', 'e');
            text = text.Replace('ê', 'e');
            text = text.Replace('à', 'a');
            text = text.Replace('ù', 'u');
            text = text.Replace('ç', 'c');
            text = text.Substring(0, text.Length - 1);

            char[] phraseInv = new char[text.Length];
            for (int i = 0; i < phraseInv.Length; i++)
            {
                phraseInv[i] = text[text.Length - 1 - i];
            }
            foreach (char lettre in phraseInv)
            {
                Console.Write(lettre);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].CompareTo(phraseInv[i]) !=0)
                {
                    test = false;
                }
            }
            if (!test)
            {
                Console.WriteLine("La phrase n'est pas un palandrome.");

            }
            else
            {
                Console.WriteLine("La phrase est un palandrome.");

            }

            Console.ReadKey();
        }
    }
}
