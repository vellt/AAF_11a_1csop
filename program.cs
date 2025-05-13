using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
     class Program
    {
        static void Main(string[] args)
        {
            // csupa i betűs
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            string iBetus = "";

            //Console.WriteLine(szoveg);

            for (int i = 0; i < szoveg.Length; i++)
            {
                char karakter = szoveg[i];

                if (karakter == 'a' || karakter == 'á' || karakter == 'e' || karakter == 'é' || karakter == 'o' || karakter == 'ó' || karakter == 'ö' || karakter == 'ő' || karakter == 'u' || karakter == 'ú' || karakter == 'ü' || karakter == 'ű')
                {
                    iBetus += 'i';
                }
                else
                {
                    iBetus += karakter;
                }
            }

            Console.WriteLine($"{szoveg} csupa i betűvel: {iBetus}");
            Console.ReadKey();
        }
    }
}
