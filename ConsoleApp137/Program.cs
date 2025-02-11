using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // File osztály miatt

namespace ConsoleApp137
{
    class Program
    {
        static void Main(string[] args)
        {
            // olvassuk be a fájlt, amit a bin/Debug mappába tettünk. 
            // Ehhez, hogy beolvassunk kellett a system.io felülre!
            string[] gyumolcsok = File.ReadAllLines("gyumolcsok.csv");

            // írassuk ki a beolvasott sorokat egymás alá
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                Console.WriteLine(gyumolcsok[i]);
            }

            // legrövidebb gyümöcsnév karakterhossza
            int min = gyumolcsok[0].Length;
            for (int i = 1; i < gyumolcsok.Length; i++)
            {
                if (gyumolcsok[i].Length<min)
                {
                    min = gyumolcsok[i].Length;
                }
            }
            Console.WriteLine($"Legrövidebb karakterhossz: {min}");

            // leghoszabb gyümöcsnév
            int max = gyumolcsok[0].Length;
            for (int i = 1; i < gyumolcsok.Length; i++)
            {
                if (gyumolcsok[i].Length > max)
                {
                    max = gyumolcsok[i].Length;
                }
            }
            Console.WriteLine($"Leghosszabb karakterhossz: {max}");

            // mennyi alma van a tömbben
            int szamlalo = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string gyumolcs = gyumolcsok[i];
                if (gyumolcs=="Alma")
                {
                    szamlalo++;
                }
            }
            Console.WriteLine(szamlalo);

            // mennyi alma és körte van a tömbben
            int szamlalo2 = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string gyumolcs = gyumolcsok[i];
                if (gyumolcs=="Körte" || gyumolcs=="Alma")
                {
                    szamlalo2++;
                }
            }
            Console.WriteLine(szamlalo2);

            // mennyi 5 karakternél hosszabb gyülölcs van a tömbben
            int szamlalo3 = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string gyumolcs = gyumolcsok[i];
                if (gyumolcs.Length > 5)
                {
                    szamlalo3++;
                }
            }
            Console.WriteLine(szamlalo3);

            // mennyi páratlan hosszúságú gyümölcs van
            int paratlan = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                int gyumolcsHossza = gyumolcsok[i].Length;
                if (gyumolcsHossza % 2 != 0)
                {
                    paratlan++;
                }
            }
            Console.WriteLine(paratlan);

            // mennyi olyan gyümölcs van, amelynél az első és utolsó karakter megegyezik
            int elsoUtolsoEgyezik = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string kicsiGyumolcs = gyumolcsok[i].ToLower();
                char elso = kicsiGyumolcs[0];
                char utolso = kicsiGyumolcs[kicsiGyumolcs.Length-1];
                if (elso==utolso)
                {
                    elsoUtolsoEgyezik++;
                }
            }
            Console.WriteLine(elsoUtolsoEgyezik);
            

            // mennyi k betű van a beolvasott gyümölcsökben
            int kBetu = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string kicsiGyumolcs = gyumolcsok[i].ToLower();
                for (int j = 0; j < kicsiGyumolcs.Length; j++)
                {
                    char karakter = kicsiGyumolcs[j];
                    if (karakter=='k')
                    {
                        kBetu++;
                    }
                }
            }
            Console.WriteLine(kBetu);
            Console.ReadKey();
        }
    }
}
