using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp190
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "abc";
            
            //5
            string feladat5 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                feladat5 += (char)(kar - 32);
            }
            Console.WriteLine(feladat5);
            File.WriteAllText("feladat5.txt", feladat5);

            //6
            string feladat6 = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                char kar = szoveg[i];
                feladat6+= (char)(kar - 32);
            }
            Console.WriteLine(feladat6);
            File.WriteAllText("feladat6.txt", feladat6);

            //7
            string feladat7 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                if (!(kar>=48 && kar<=57))
                {
                    feladat7 += kar;
                }
            }
            Console.WriteLine(feladat7);
            File.WriteAllText("feladat7.txt", feladat7);

            // 8
            string feladat8 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                if (!(kar>=65 && kar<=90))
                {
                    feladat8 += kar;
                }
            }
            Console.WriteLine(feladat8);
            File.WriteAllText("feladat8.txt", feladat8);

            // 9
            string feladat9 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                if (kar==32)
                {
                    feladat9 += '-';
                }
                else if(kar>=65 && kar<=90)
                {
                    feladat9 += (char)(kar + 32);
                }
                else
                {
                    feladat9 += kar;
                }
            }
            Console.WriteLine(feladat9);
            File.WriteAllText("feladat9.txt", feladat9);

            //10
            string feladat10 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                if (kar==97 || kar==101 || kar==105 || kar==111 ||kar==117)
                {
                    feladat10 += kar;
                    feladat10 += kar;
                }
                else
                {
                    feladat10 += kar;
                }
            }
            Console.WriteLine(feladat10);
            File.WriteAllText("feladat10.txt", feladat10);

            Console.ReadKey();
        }
    }
}
