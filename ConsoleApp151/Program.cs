using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp151
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hozzunk létre egy felhasználó által megadott hosszúságú tömböt. Az
            elemeit töltsük fel [-10,30]-ban. Majd végezzük el a következő feladatokat:
             */

            Console.Write("Add meg a tömb hosszát: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] tomb = new int[n];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(41) - 10;
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();

            // A legnagyobb elem megtalálása
            int max = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i]>max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine($"A tömb legnagyobb értéke: {max}");

            // Mennyi 12-es van a tömbben
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]==12)
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // Mennyi az összege a tömbnek
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine(osszeg);

            Console.ReadKey();

        }
    }
}
