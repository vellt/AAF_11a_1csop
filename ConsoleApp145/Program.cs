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
                if (nevek[i].Length<10)
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

            // kérd be sorszámot, és megmondom a tanuló nevét
            Console.WriteLine($"Összesen: {nevek.Length} tanuló van");
            int valasztott = Convert.ToInt32(Console.ReadLine());
            int index = valasztott - 1;
            string diakNeve = nevek[index];
            Console.WriteLine(diakNeve);

            // Mennyi a leghosszabb név karakterhossza
            int max = nevek[0].Length;
            for (int i = 1; i < nevek.Length; i++)
            {
                if (nevek[i].Length>max)
                {
                    max = nevek[i].Length;
                }
            }
            Console.WriteLine(max);

            // Van a listában olyan név amely 20 karakter feletti?

            bool van = false;
            for (int i = 0; i < nevek.Length && van==false; i++)
            {
                if (nevek[i].Length>20)
                {
                    van = true;
                }
            }

            if (van)
            {
                Console.WriteLine("van benne 20 karakter feletti");
            }
            else
            {
                Console.WriteLine("nincs benne 20 karakter feletti");
            }

            Console.WriteLine(van? "van":"nincs");


            // Van Sörös Sándor a listában?

            bool van2 = false;
            for (int i = 0; i < nevek.Length && van2==false; i++)
            {
                if (nevek[i]=="Sörös Sándor")
                {
                    van2 = true;
                }
            }
            Console.WriteLine(van2 ? "van" : "nincs");

            // Van olyan név, ahol két keresztnév van?
            bool van3 = false;
            for (int i = 0; i < nevek.Length && van3==false; i++)
            {
                string[] nevreszek = nevek[i].Split(' ');
                if (nevreszek.Length==3)
                {
                    van3 = true;
                }
            }
            Console.WriteLine(van3 ? "van" : "nincs");

            // Van olyan név, amelynek a karakterhossza páratlan?
            bool van4 = false;
            for (int i = 0; i < nevek.Length && van4==false; i++)
            {
                if (nevek[i].Length%2!=0)
                {
                    van4 = true;
                }
            }
            Console.WriteLine(van4 ? "van" : "nincs");

            // Hanyadik helyen van a tömbben Sunyi Béla?
            int index2 = -1;
            for (int i = 0; i < nevek.Length && index2==-1; i++)
            {
                if (nevek[i]=="Sunyi Béla")
                {
                    index2 = i;
                }
            }
            Console.WriteLine(index2);
            Console.WriteLine(nevek[index2]); // Sunyi Béla


            // hanyadik helyen van a tömbben Csavar Pista?
            int index3 = -1;
            for (int i = 0; i < nevek.Length && index3==-1; i++)
            {
                if (nevek[i]=="Csavar Pista")
                {
                    index3 = i;
                }
            }
            Console.WriteLine(index3==-1?"nincs ilyen": $"{nevek[index3]} itt van: {index3}");

            //hanyadik helyen van a leghosszabb név?

            int maxIndex = 0;
            int maxErtek = nevek[0].Length;
            for (int i = 1; i < nevek.Length; i++)
            {
                if (maxErtek<nevek[i].Length)
                {
                    maxIndex = i;
                    maxErtek = nevek[i].Length;
                }
            }
            Console.WriteLine($"A leghosszabb nevű indexe: {maxIndex}");
            Console.WriteLine($"A leghosszabb nevű tanuló: {nevek[maxIndex]}");

            Console.ReadKey();
        }
    }
}
