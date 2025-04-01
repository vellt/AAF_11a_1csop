using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp173
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1. feladat");
                string[] nevek = File.ReadAllLines("harry_potter.txt");

                Console.WriteLine($"2. feladat: {nevek.Length}");

                Console.WriteLine("3. feladat");
                for (int i = 0; i < nevek.Length; i++)
                {
                    Console.Write($"{(i+1).ToString("00")}. {nevek[i],-25}");
                    if ((i+1)%4==0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("4. feladat");
                string elsoNev =nevek[0];
                string utolsoNev = nevek[nevek.Length - 1];
                if (utolsoNev[utolsoNev.Length-1]==elsoNev[elsoNev.Length-1])
                {
                    Console.WriteLine("egyfroma");
                }
                else
                {
                    Console.WriteLine("különböző");
                }

                // 5. Jelenítsd meg azon szereplőket egymás alatt, 
                //melyek karakterhossza páratlan.
                Console.WriteLine("5. feladat");
                for (int i = 0; i < nevek.Length; i++)
                {
                    if (nevek[i].Length % 2 != 0) 
                    {
                        Console.WriteLine(nevek[i]);
                    }
                }

                // 6. feladat:
                Console.Write("6. feladat: Adj meg egy nevet: ");
                string szoveg = Console.ReadLine().ToLower();
                bool letezik = false;
                for (int i = 0; i < nevek.Length && letezik==false; i++)
                {
                    string nev = nevek[i].ToLower();
                    if (nev==szoveg)
                    {
                        letezik = true;
                    }
                }
                Console.WriteLine(letezik ? "van" : "nincs");

                //7
                Console.WriteLine("7. feladat");
                bool mindegyik = true;
                for (int i = 0; i < nevek.Length && mindegyik==true; i++)
                {
                    string nev = nevek[i];
                    char elso = nev[0];
                    if (elso!='H')
                    {
                        mindegyik = false;
                    }
                }
                Console.WriteLine(mindegyik?"igen":"nem");


                //8
                Console.WriteLine("8. feladat");
                int szamlalo = 0;
                for (int i = 0; i < nevek.Length; i++)
                {
                    string vezeteknev = nevek[i].Split(' ')[1];
                    if (vezeteknev=="Weasley")
                    {
                        szamlalo++;
                    }
                }
                Console.WriteLine(szamlalo);

                // 9
                Console.WriteLine("9. feladat");
                Console.Write("Adj egy szórészletet: ");
                string szoreszlet = Console.ReadLine(); // pl "er"
                for (int i = 0; i < nevek.Length; i++)
                {
                    if (nevek[i].Contains(szoreszlet))
                    {
                        Console.WriteLine(nevek[i]);
                    }
                }

                // 10
                Console.WriteLine("10. feladat");
                int maxIndex = 0;
                int maxEdbSzam = 0;
                for (int i = 0; i < nevek.Length; i++)
                {
                    string nev = nevek[i].ToLower();
                    int dbSzam = 0; //e betűk száma az adott névnek
                    for (int j = 0; j < nev.Length; j++)
                    {
                        if (nev[j] == 'e')
                        {
                            dbSzam++;
                        }
                    }
                    if (maxEdbSzam<dbSzam)
                    {
                        maxEdbSzam = dbSzam;
                        maxIndex = i;
                    }
                }
                Console.WriteLine($"{maxIndex+1}. helyen van a legtöbb e betűt tart. szöveg");


                // 11. feladat
                Console.WriteLine("11. feladat");
                int osszKarakterhossz = 0;
                for (int i = 0; i < nevek.Length; i++)
                {
                    osszKarakterhossz += nevek[i].Length;
                }
                double atlag = osszKarakterhossz / (double)nevek.Length;
                Console.WriteLine(Math.Round(atlag, 2));

            }
            catch (Exception)
            {
                Console.WriteLine("1. feladat: Hiba történt..");
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
