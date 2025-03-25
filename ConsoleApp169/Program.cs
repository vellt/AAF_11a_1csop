using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp169
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1
                string[] nevek = File.ReadAllLines("harry_potter.txt");
                Console.WriteLine("A fájl beolvasása sikeres");
                
                // 2
                Console.WriteLine(nevek.Length);
                
                // 3
                for (int i = 0; i < nevek.Length; i++)
                {
                    Console.Write($"{(i+1).ToString("00")}. {nevek[i],-25}");
                    if ((i+1)%4==0)
                    {
                        Console.WriteLine();
                    }
                    
                }
                
                // 4
                string elsoSzoveg = nevek[0];
                string utolsoSzoveg = nevek[nevek.Length-1];

                char elsoUtolso = elsoSzoveg[elsoSzoveg.Length - 1];
                char utolsoUtolso = utolsoSzoveg[utolsoSzoveg.Length - 1];
                
                Console.WriteLine(elsoUtolso==utolsoUtolso?"igen":"nem");
                
                // 5
                for (int i = 0; i < nevek.Length; i++)
                {
                    if (nevek[i].Length%2!=0)
                    {
                        Console.WriteLine(nevek[i]);
                    }
                }

                // 6
                Console.Write("Adj meg egy szereplőt: ");
                string szereplo = Console.ReadLine();
                bool van = false;
                for (int i = 0; i < nevek.Length && van==false; i++)
                {
                    if (szereplo.ToLower()==nevek[i].ToLower())
                    {
                        van = true;
                    }
                }
                Console.WriteLine(van?"van":"nincs");

                // 7
                bool mindegyik = true;
                for (int i = 0; i < nevek.Length && mindegyik==true; i++)
                {
                    if (nevek[i][0] != 'H')
                    {
                        mindegyik = false;
                    }
                }
                Console.WriteLine(mindegyik?"igen":"nem");

                //8. feladat
                int db = 0;
                for (int i = 0; i < nevek.Length; i++)
                {
                    string vezeteknev = nevek[i].Split(' ')[1];
                    if (vezeteknev == "Weasley")
                    {
                        db++;
                       
                    }
                }
                Console.WriteLine(db);

                // HF: 9, 10, 11
            }
            catch (Exception)
            {
                Console.WriteLine("A fájl beolvasása során hiba lépett fel");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
