using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp148
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg hányszor induljon a busz: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N<2)
            {
                Console.WriteLine("Minimum kétszer kell indulnia a busznak");
            }
            else
            {
                int[] buszjaratok = new int[N];
                Random r = new Random();
                for (int i = 0; i < buszjaratok.Length; i++)
                {
                    buszjaratok[i] = r.Next(41)+20; // [20,60]
                }

                // 1
                int elso = buszjaratok[0];
                int utolso = buszjaratok[buszjaratok.Length-1];
                if (elso==utolso)
                {
                    Console.WriteLine("első és az utolsó egyforma mennyiségű utas volt");
                }
                else
                {
                    Console.WriteLine("különböző");
                }

                // 2
                int osszes = 0;
                for (int i = 0; i < buszjaratok.Length; i++)
                {
                    osszes += buszjaratok[i];
                }

                double atlag = osszes / (double)buszjaratok.Length;

                Console.WriteLine(Math.Round(atlag, 2));

                // 3 
                bool csokken = true;
                for (int i = 0; i <buszjaratok.Length -1 && csokken==true; i++)
                {
                    int a = buszjaratok[i];
                    int b = buszjaratok[i + 1];
                    if (a<b)
                    {
                        csokken = false;
                    }
                }
                Console.WriteLine(csokken?"folyamatosan csökken":"nem csökken f");

                // 4
                bool van = false;
                for (int i = 0; i < buszjaratok.Length && van==false; i++)
                {
                    if (buszjaratok[i]<atlag)
                    {
                        van = true;
                    }
                }

                Console.WriteLine(van?"van átlag alatti":"nincs");

                // 5
                int db = 0;
                for (int i = 0; i < buszjaratok.Length; i++)
                {
                    if (buszjaratok[i]==20)
                    {
                        db++;
                    }
                }
                Console.WriteLine(db);

            }
            Console.ReadKey();
        }
    }
}
