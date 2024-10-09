```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            // random számok generálása
            Random r = new Random();
            int sz1 = r.Next(100); // [0,99]
            int sz2 = r.Next(101) - 50; // [-50,50]
            int sz3 = r.Next(7) + 2; // [2,8]
            int sz4 = r.Next(7) + 4; // [4,10]
            int sz5 = r.Next(7) + 25; // [25,31]
            int sz6 = r.Next(82) + 0; // [0,81] itt a plusz 0 az nem kötelező!
            int sz7 = r.Next(6) - 2; // [-2,3]
            int sz8 = r.Next(6) - 10; // [-10, -5]
            int sz9 = r.Next(4) - 15; // [-15, -12]
            int sz10 = r.Next(81) - 30; // [-30, 50]
            
            // -----------------------------------------------
            // ciklusok
            // írjuk ki 5x hogy hello, majd 10000x,azért látszik, hogy 5-nél még
            // csak csak megcsináljuk, de 10000x történőismétlésnél már nem ctrl+c-zünk
            // erre lesznek a ciklusok, hogy az ismétlődést automatikusan elvégezze
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");

            // 5x írjuk, ki, hogy hello
            int lepes = 0;
            while (lepes<5)
            {
                Console.WriteLine("hello");
                lepes++;
            }

            Console.ReadKey();

        }
    }
}


```