using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp145
{
    class Program
    {
        static void Main(string[] args)
        {
            // Olvasd be a nevek.txt fájlt (be kell tenni a bin/Debugba), és tedd bele egy string tömbbe, majd véged el a következő feladatokat:
            string[] nevek = File.ReadAllLines("nevek.txt");

            // Listázd ki a neveket egymás mellé szóközzel elválasztva
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write($"{nevek[i]} ");
            }
            Console.WriteLine();

            //  Mennyi olyan B betűvel kezdődő név van
            int db = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                if (nev[0]=='B')
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // Mennyi olyan név van ahol az utolsó karakter r betű
            int db2 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                if (nev[nev.Length-1]=='r')
                {
                    db2++;
                }
            }
            Console.WriteLine(db2);

            // Mennyi olyan név van amelynek a kezdő és utolsó karaktere egyforma
            int db3 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i].ToLower();
                if (nev[0]==nev[nev.Length-1])
                {
                    db3++;
                }
            }
            Console.WriteLine(db3);

            // Mennyi 10 karakter alatti név van
            int db4 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek.Length<10)
                {
                    db4++;
                }
            }
            Console.WriteLine(db4);

            // Mennyi Sándor van?
            int db5 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string keresztnev = nevek[i].Split(' ')[1]; // ha [0]-->vezetéknév
                if (keresztnev=="Sándor")
                {
                    db5++;
                }
            }
            Console.WriteLine(db5);

            // Mennyi az összkarakterhossz
            int osszeg = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                osszeg += nevek[i].Length;
            }
            Console.WriteLine(osszeg);

            // Mennyi a karakterhosszak átlaga a neveknek
            double atlag = Convert.ToDouble(osszeg) / nevek.Length;
            Console.WriteLine(Math.Round(atlag, 2));

            // Mennyi a legrövidebb név karakterhossza
            int min = nevek[0].Length;
            for (int i = 1; i < nevek.Length; i++)
            {
                if (nevek[i].Length<min)
                {
                    min = nevek[i].Length;
                }
            }
            Console.WriteLine(min);
             
            Console.ReadKey();
        }
    }
}
