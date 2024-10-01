```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Add meg az x értékét");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg az y értékét");
            y = Convert.ToInt32(Console.ReadLine());

            double z = (x + y) / 2.0;
            Console.WriteLine($"2-szám mértani közepe: {Math.Round(z,2)}");
            
            // -------------------------------------------------------------

            int a1,a2,b1,b2;
            double D;
            Console.Write("Add meg a1 értékét: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a2 értékét: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg b1 értékét: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg b2 értékét: ");
            b2 = Convert.ToInt32(Console.ReadLine());

            D = Math.Sqrt((b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2));
            Console.WriteLine($"Két koordináta távolsága:{Math.Round(D,3)}");
            
            
            // -------------------------------------------------------------
            // Másodfokú egyenlet
 
            int a, b,  c, d;
            double x1, x2;
            Console.Write("Add meg az a értékét: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg az b értékét: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg az c értékét: ");
            c = Convert.ToInt32(Console.ReadLine());

            d =(int)Math.Pow(b, 2)-4*a*c;
            if (d<0) // diszkrimináns étéke nem lehet negatív
            {
                Console.WriteLine("Nem kiszámitható");
            }
            else 
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Az x1 értéke ez: {Math.Round(x1,2)}");
                Console.WriteLine($"Az x2 értéke ez: {Math.Round(x2,2)}");
            }
            

            Console.ReadKey();
        }
    }
}


```