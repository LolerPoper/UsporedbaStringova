using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsporedbaStringova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst.";
            string tekst2 = "Ovo je NEKI tekst.";
            string tekst3 = "ovo je neki tekst.";
            string tekst4 = "Ovo je neki tekst.";

            // Korištenje compare statičke metode

            if (string.Compare(tekst1, tekst2) == 0)
            {
                Console.WriteLine("Ova dva teksta su ista.");
            }
            else
            {
                Console.WriteLine("Ova dva teskta nisu ista.");
            }
            if (string.Compare(tekst1, tekst3) == 0)
            {
                Console.WriteLine("Ova dva teksta su ista.");
            }
            else
            {
                Console.WriteLine("Ova dva teskta nisu ista.");
            }
            if (string.Compare(tekst1, tekst4) == 0)
            {
                Console.WriteLine("Ova dva teksta su ista.");
            }
            else
            {
                Console.WriteLine("Ova dva teskta nisu ista.");
            }

            // Korištenje bool varijabli
            // Različiti stringovi
            Console.WriteLine(tekst1 == tekst2);
            Console.WriteLine(tekst1 == tekst3);
            // Jednaki stringovi
            Console.WriteLine(tekst1 == tekst4);

            Console.ReadKey();
        }
    }
}
