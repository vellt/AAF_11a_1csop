using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp167
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] nevek = File.ReadAllLines("Nevek.txt");
            
            //2
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            //3
            for (int i = 0; i < nevek.Length; i+=2)
            {
                Console.WriteLine(nevek[i]);
            }

            //4
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i].ToLower());
            }

            //5
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i].ToUpper());
            }

            //6
            for (int i = nevek.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nevek[i]);
            }

            //7
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                for (int j = 0; j < nev.Length; j++)
                {
                    if (nev[j]!=' ')
                    {
                        Console.Write(nev[j]);
                    }
                }
                Console.WriteLine();
            }

            //8
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i].ToUpper();
                for (int j = 0; j < nev.Length; j++)
                {
                    if (nev[j] != ' ')
                    {
                        Console.Write(nev[j]);
                    }
                }
                Console.WriteLine();
            }

            //9
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                for (int j = nev.Length - 1; j >= 0; j--)
                {
                    Console.Write(nev[j]);
                }
                Console.WriteLine();
            }

            //10
            for (int i = nevek.Length - 1; i >= 0; i--)
            {
                string nev = nevek[i];
                for (int j = nev.Length - 1; i >= 0; i--)
                {
                    Console.Write(nev[j]);
                }
                Console.WriteLine();
            }

            // 11
            Console.Write("Szórészlet: ");
            string szoreszlet = Console.ReadLine().ToLower();
            int db = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i].ToLower();
                if (nev.Contains(szoreszlet))
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // 12
            Console.Write("Szórészlet: ");
            string szoreszlet2 = Console.ReadLine().ToLower();
            int db2 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i].ToLower();
                if (nev.StartsWith(szoreszlet2))
                {
                    db2++;
                }
            }
            Console.WriteLine(db2);

            //13
            int szamlalo = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                if (nev.Length % 2 != 0)
                {
                    szamlalo++;
                }
            }
            Console.WriteLine(szamlalo);

            //14
            int szamlalo2 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                char elso = nev[0];
                if (elso=='C')
                {
                    szamlalo2++;
                }
            }
            Console.WriteLine(szamlalo2);

            // 15
            int szamlalo3 = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                char utolso = nev[nev.Length-1];
                if (utolso == 's')
                {
                    szamlalo3++;
                }
            }
            Console.WriteLine(szamlalo3);

            // 17
            bool van = false;
            for (int i = 0; i < nevek.Length && van==false; i++)
            {
                if (nevek[i].Length%2==0)
                {
                    van = true;
                }
            }
            Console.WriteLine(van ? "igen" : "nincs");

            // 16 
            int index = -1;
            for (int i = 0; i < nevek.Length && index==-1; i++)
            {
                string nev = nevek[i];
                string keresztnev = nev.Split(' ')[1];
                if (keresztnev=="Sándor")
                {
                    index = i;
                }
            }
            if (index==-1)
            {
                Console.WriteLine("Nincs Sándor");
            }
            else
            {
                Console.WriteLine($"{index+1}. helyen van ${nevek[index]}");
            }
            

            Console.ReadKey();
        }
    }

}
