using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp189
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = File.ReadAllText("watchmen.txt");
            // van-e mondatvégi írásjel
            bool van = false;
            for (int i = 0; i < szoveg.Length && van==false; i++)
            {
                char kar = szoveg[i];
                if (kar==33 || kar==63 || kar==46)
                {
                    van = true;
                }
            }

            //van-e aritmetikai
            bool van2 = false;
            for (int i = 0; i < szoveg.Length && van2==false; i++)
            {
                char karakter = szoveg[i];
                if (karakter==37 ||
                    karakter==42 || 
                    karakter== 43 || 
                    karakter== 45 ||
                    karakter== 47)
                {
                    van2 = true;
                }
            }
            Console.WriteLine(van2?"van": "nincs");

            // van betű a szövegben?
            bool van3 = false;
            for (int i = 0; i < szoveg.Length && van3==false; i++)
            {
                char karakter3 = szoveg[i];
                if (karakter3 >= 65 && karakter3 <= 90 ||
                    karakter3 >= 97 && karakter3 <= 122) 
                {
                    van3 = true;
                }
            }
            Console.WriteLine(van3?"van":"nincs");

            Console.ReadKey();
        }
    }
}
