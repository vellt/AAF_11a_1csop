using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp184
{
    class Program
    {
        static void Main(string[] args)
        {
            // beolvassuk a watchmen.txt-t string-be
            string szoveg = File.ReadAllText("watchmen.txt");
            // mennyi nagybetű van benne
            int nagybetukSzama = 0;
            int kisbetukSzama = 0;
            int kotojelSzama = 0;
            int maganhangzokSzama = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                char karakter = szoveg[i];
                if (karakter>=65 && karakter<=90) // nagybetűs karakter
                {
                    nagybetukSzama++;
                }
                if (karakter >= 97 && karakter <= 122) // mennyi kisbetűs van
                {
                    kisbetukSzama++;
                }
                if (karakter==45) // mennyi kötőjel
                {
                    kotojelSzama++;
                }
                if (karakter==65  ||
                    karakter==97  ||
                    karakter==101 ||
                    karakter==69  ||
                    karakter==105 ||
                    karakter==73  ||
                    karakter==111 ||
                    karakter==79  ||
                    karakter==117 ||
                    karakter==85
                    ) // mennyi magánhanzó
                {
                    maganhangzokSzama++;
                }
            }
            Console.WriteLine("1. feladat");
            Console.WriteLine(nagybetukSzama);
            Console.WriteLine(kisbetukSzama);
            Console.WriteLine(kotojelSzama);
            Console.WriteLine(maganhangzokSzama);

            //2
            int aritmetikai = 0;
            int szam = 0;
            int e = 0;
            int kisbetu = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                char karakter = szoveg[i];
                if (karakter == 43 ||
                    karakter == 45 ||
                    karakter == 42 ||
                    karakter == 47 ||
                    karakter == 37) 
                {
                    aritmetikai++;
                }
                if (karakter >= 48 && karakter <= 57 )
                {
                    szam++;
                }
                if (karakter == 69 || karakter == 101) 
                {
                    e++;
                }
                if (karakter >= 97 && karakter <= 122) 
                {
                    kisbetu++;
                }

            }
            int aritmetikaiSzazalek = Convert.ToInt32(aritmetikai / (double)szoveg.Length * 100);
            int szamSzazalek = Convert.ToInt32(szam / (double)szoveg.Length * 100);
            int eSzazalek = Convert.ToInt32(e / (double)szoveg.Length * 100);
            int kisbetuSzazalek = Convert.ToInt32(kisbetu / (double)szoveg.Length * 100);
            Console.WriteLine("2. feladat");
            Console.WriteLine($"aritmetikai: {aritmetikaiSzazalek}%");
            Console.WriteLine($"számok: {szamSzazalek}%");
            Console.WriteLine($"e betűk: {eSzazalek}%");
            Console.WriteLine($"kisbetűk: {kisbetuSzazalek}%");

            // 3. feladat
            Console.WriteLine("3. feladat");
            bool vanSzam = false;
            for (int i = 0; i < szoveg.Length && vanSzam==false; i++)
            {
                char karakter = szoveg[i];
                if (karakter>=48 && karakter<=57)
                {
                    vanSzam = true;
                }
            }
            Console.WriteLine(vanSzam ? "van szám" : "nincs szám");

            bool vanszam2 = false;
            for (int i = 0; i < szoveg.Length &&  vanszam2==false; i++)
            {
                char karakter = szoveg[i];
                if (karakter == 65  ||
                    karakter == 97  ||
                    karakter == 101 ||
                    karakter == 69  ||
                    karakter == 105 ||
                    karakter == 73  ||
                    karakter == 111 ||
                    karakter == 79  ||
                    karakter == 117 ||
                    karakter == 85 ) 
                {
                    vanszam2 = true;
                }
            }
            Console.WriteLine(vanszam2 ? "van magánhangzó" : "nincs magánhangzó");

            Console.ReadKey();
        }
    }
}
