using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Add meg a tömb hosszát: ");
            int hossz = Convert.ToInt32(Console.ReadLine());
            
            // 2
            int[] tomb = new int[hossz];

            // 3
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();

            // 4
            //[45,70]
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(26) + 45;
            }

            // 5
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();

            // 6
            for (int i = 0; i < tomb.Length; i+=5)
            {
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();

            // 7
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>50 && tomb[i]%2==0)
                {
                    Console.Write($"{tomb[i]} ");
                }
            }
            Console.WriteLine();

            // 8
            int min = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i]<min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine($"A tömb legkisebb értéke: {min}");

            // 9
            // a, b, c, d
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                // a
                if (tomb[i]%2==0)
                {
                    a++;
                }
                // b
                if (tomb[i] >=40 && tomb[i] <=50)
                {
                    b++;
                }
                // c
                if (tomb[i]>60)
                {
                    c++;
                }
                // d
                if (tomb[i]%10==0)
                {
                    d++;
                }
            }
            Console.WriteLine($"a: {a}db");
            Console.WriteLine($"b: {b}db");
            Console.WriteLine($"c: {c}db");
            Console.WriteLine($"d: {d}db");

            // 10 összegzés
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }

            // 11. 
            double atlag = osszeg / Convert.ToDouble(tomb.Length);
            Console.WriteLine(Math.Round(atlag,2));

            // mennyi a tömb legnagyobb értéke
            int max = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[0];
                }
            }
            Console.WriteLine(max);

            // mennyi 5-el osztható páros szám van benne
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%5==0 && tomb[i]%2==0)
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // döntsd el és írasd ki hogy a tömb első és utolsó eleme egyoforma-e
            int elso = tomb[0];
            int utolso = tomb[tomb.Length - 1];
            if (elso==utolso)
            {
                Console.WriteLine("Egyezik");
            }
            else
            {
                Console.WriteLine("nem egyezik");
            }

            // jelenítsd meg az 50 alatti elemet
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]<50)
                {
                    Console.Write($"{tomb[i]} ");
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
