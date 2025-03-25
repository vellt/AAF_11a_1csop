using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp168
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1
                string[] hegycsucsok = File.ReadAllLines("hegycsucsok.txt");
                Console.WriteLine("\n1. feladat: a fájl sikeresen beolvasva");

                // 2
                int hossz = hegycsucsok.Length;
                Console.WriteLine($"\n2. feladat: Sorok száma: {hossz}");

                // 3
                Console.WriteLine("\n3. feladat:");
                for (int i = 0; i < hegycsucsok.Length; i++)
                {
                    Console.Write($"{(i+1).ToString("00")}. {hegycsucsok[i],-25}");

                    if ((i + 1) % 4 == 0) 
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();

                // 4
                string elso = hegycsucsok[0];
                string utolso = hegycsucsok[hegycsucsok.Length - 1];
                bool megegyezik = elso == utolso;

                Console.WriteLine($"\n4. feladat: {(megegyezik ? "igen" : "nem")}");

                /* // színesben
                Console.Write($"\n4. feladat: ");
                if (megegyezik)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("igen");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nem");
                }
                Console.ResetColor();
                */

                // 5
                Console.WriteLine("5. feladat:");
                for (int i = 0; i < hegycsucsok.Length; i++)
                {
                    if (hegycsucsok[i].Length<8)
                    {
                        Console.WriteLine($"- {hegycsucsok[i]}");
                    }
                }

                // 6
                Console.Write("\n6. feladat: Adj meg egy hegycsúcsot: ");
                string bekertSzoveg = Console.ReadLine().ToLower();
                bool van = false;
                for (int i = 0; i < hegycsucsok.Length && van==false; i++)
                {
                    string hegycsucs = hegycsucsok[i].ToLower();
                    if (bekertSzoveg==hegycsucs)
                    {
                        van = true;
                    }
                }
                Console.WriteLine(van ? "van" : "nincs");

                // 7
                Console.Write("\n7. feladat: ");
                bool mindegyik = true;
                for (int i = 0; i < hegycsucsok.Length && mindegyik==true; i++)
                {
                    if (hegycsucsok[i].Length>=10)
                    {
                        mindegyik = false;
                    }
                }
                Console.WriteLine(mindegyik?"mindegyik 10 karakter alatti":"nem minden");
                
                // 8
                int szamlalo2 = 0;
                for (int i = 0; i < hegycsucsok.Length; i++)
                {
                    if (hegycsucsok[i].Contains("-"))
                    {
                        szamlalo2++;
                    }
                }
                Console.WriteLine($"Ennyi '-'-es szo van{szamlalo2}");
                
                // 9
                int szamlalo = 0;
                string szoreszlet = Console.ReadLine().ToLower();
                for (int k = 0; k < hegycsucsok.Length; k++)
                {
                    string hegycsucs = hegycsucsok[k].ToLower();
                    if (hegycsucs.Contains(szoreszlet))
                    {
                        szamlalo++;
                    }
                }
                Console.WriteLine($"\n9. feladat: {szamlalo}");

                // 10
                int maxindex = 0;
                for (int i = 1; i < hegycsucsok.Length; i++)
                {
                    if (hegycsucsok[maxindex].Length<hegycsucsok[i].Length)
                    {
                        maxindex = i;
                    }
                }
                Console.WriteLine($"A leghosszabb heg neve: {hegycsucsok[maxindex]}");
                
                // 11
                int oszhossz = 0;
                for (int i = 0; i < hegycsucsok.Length; i++)
                {
                    oszhossz += hegycsucsok[i].Length;
                }
                double atlag = (double)oszhossz / hegycsucsok.Length;

                Console.WriteLine(Math.Round(atlag,2));
            }
            

            catch (Exception)
            {
                Console.WriteLine("\n1. feladat: Hiba történt a fájl beolvasása során");
            } finally
            {
                Console.ReadKey();
            }
        }
    }
}
