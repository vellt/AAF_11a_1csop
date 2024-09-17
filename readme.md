```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // kocka felszíne (A), térfogata (V)   

            double a,A,V;
            Console.WriteLine("Add meg az a értékét.");
            a = Convert.ToDouble(Console.ReadLine());
            A = 6* Math.Pow(a,2);
            V = Math.Pow(a, 3);
            Console.WriteLine($"A={Math.Round(A,2)}");
            Console.WriteLine($"V={V:0.00}");
            
            //---------------------------------------------------
            // henger felszíne (A), térfogata (V)

            double r, m, V, A;
            Console.WriteLine("Add meg az r értékét");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg az m értékét");
            m = Convert.ToDouble(Console.ReadLine());
            A = 2 * r * r * Math.PI + 2 * r * Math.PI * m;
            V = r * r * Math.PI * m;
            Console.WriteLine($"A={Math.Round(A,3)}");
            Console.WriteLine($"V={V:0.000}");

            //---------------------------------------------------
            // köbgyök-->hatványazonosság

            int x;
            double eredmeny;
            Console.WriteLine("Adj meg egy számot és megmondom a kbgyökét");
            x = Convert.ToInt32(Console.ReadLine());
            eredmeny = Math.Pow(x, 1 / (double)3);
            Console.WriteLine($"eredmeny={Math.Round(eredmeny,4)}");

            //---------------------------------------------------
            // kasszás program

            int db500, db1000, db2000, db5000, db10000, db20000, osszesen;

            Console.WriteLine("500=");
            db500 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1000=");
            db1000 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2000=");
            db2000 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("5000=");
            db5000 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("10000=");
            db10000 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("20000=");
            db20000 = Convert.ToInt32(Console.ReadLine());

            osszesen = 500 * db500 + 
                1_000 * db1000 + 
                2_000 * db2000 + 
                5_000 * db5000 + 
                10_000 * db10000 + 
                20_000 * db20000;

            Console.WriteLine($"A pénztárban: {osszesen} Forint van");
            double bonusz = osszesen * 0.05;
            Console.WriteLine($"Ennyi forint jár a kasszásnak: {bonusz}");

            //---------------------------------------------------
            // Adj meg két számot és megmondom melyik a nagyobb!

            int a, b;
            Console.Write("Add meg egy számot: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg még egy számot: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }


            Console.ReadKey(); // a képernyőt nem zárja be, ha ez itt van!
        }
    }
}

```