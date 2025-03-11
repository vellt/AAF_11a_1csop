using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp155
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek= File.ReadAllLines("nevek.txt");
            // 1. feladat
            Console.WriteLine($"mennyi név: {nevek.Length}db");

            // 2. feladat
            bool mindegyik = true;
            for (int i = 0; i < nevek.Length && mindegyik==true; i++)
            {
                int nevekSzama = nevek[i].Split(' ').Length;
                if (nevekSzama!=2)
                {
                    mindegyik = false;
                }
            }
            Console.WriteLine(mindegyik?"igen":"nem");

            // 3
            int db = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                int nevekSzama = nevek[i].Split(' ').Length;
                if (nevekSzama==3)
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // 4.
            int db2 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                char elsoKarakter = nevek[i][0];
                if (elsoKarakter=='S')
                {
                    db2++;
                }
            }
            Console.WriteLine(db2);

            // 5. 
            int db3 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string[] nevReszek = nevek[i].Split(' ');
                bool van = false;
                for (int j = 1; j < nevReszek.Length && van==false; j++)
                {
                    string keresztnev = nevReszek[j];
                    if (keresztnev[0]=='G')
                    {
                        van = true;
                    }
                }
                if (van==true)
                {
                    db3++;
                }
            }
            Console.WriteLine($"Ennyi G-betűvel kezdődő keresztnév van: {db3}db");

            // 6
            int db4 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string[] nevReszek = nevek[i].Split(' ');
                bool van = false;
                for (int j = 1; j < nevReszek.Length && van==false; j++)
                {
                    if (nevReszek[j]=="Sándor")
                    {
                        van = true;
                    }
                }
                if (van==true)
                {
                    db4++;
                }
            }
            Console.WriteLine(db4);

            // 7
            int legrovidebb = nevek[0].Length;
            for (int i = 1; i < nevek.Length; i++)
            {
                if (nevek[i].Length < legrovidebb)
                {
                    legrovidebb = nevek[i].Length;
                }
            }
            Console.WriteLine(legrovidebb);

            // 8
            int db5 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string vezeteknev = nevek[i].Split(' ')[0];
                if (vezeteknev.Length<10)
                {
                    db5++;
                }
            }
            Console.WriteLine(db5);

            Console.ReadKey();
        }
    }
}
