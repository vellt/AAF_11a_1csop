```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x: ");
            x= Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());

            double a1 = Math.PI * Math.Pow(x, 3) + 2 * y;
            double a2 = x * Math.Pow(y, -4 * y) + Math.Pow(x, y);
            double b1 = Math.Sqrt(2 * x + 5) + 2;
            double b2 = Math.Pow(4 * Math.Pow(y, 2) + 6 * Math.PI, 1 / 3.0);
            double c1 = (Math.Pow(x, 2) + Math.Pow(2, x)) / (y + x);
            double c2 = Math.Pow(x, 5) / (3 * Math.Pow(y, 4) * y);
            double d1 = Convert.ToDouble(3 * x - y) / (x + 1);
            double d2 = Math.Pow(Math.PI, 1.0 / y);

            if (a1>a2)
            {
                Console.WriteLine($"{Math.Round(a1,2)} nagyobb, mint {Math.Round(a2,2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(a1 - a2,2)}");
            }
            if (a1 < a2)
            {
                Console.WriteLine($"{Math.Round(a2,2)} nagyobb, mint {Math.Round(a1,2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(a2 - a1,2)}");
            }

            if (b1 > b2)
            {
                Console.WriteLine($"{Math.Round(b1, 2)} nagyobb, mint {Math.Round(b2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(b1 - b2, 2)}");
            }
            if (b1 < b2)
            {
                Console.WriteLine($"{Math.Round(b2, 2)} nagyobb, mint {Math.Round(b1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(b2 - b1, 2)}");
            }


            if (c1 > c2)
            {
                Console.WriteLine($"{Math.Round(c1, 2)} nagyobb, mint {Math.Round(c2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(c1 - c2, 2)}");
            }
            if (c1 < c2)
            {
                Console.WriteLine($"{Math.Round(c2, 2)} nagyobb, mint {Math.Round(c1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(c2 - c1, 2)}");
            }

            if (d1 > d2)
            {
                Console.WriteLine($"{Math.Round(d1, 2)} nagyobb, mint {Math.Round(d2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(d1 - d2, 2)}");
            }
            if (d1 < d2)
            {
                Console.WriteLine($"{Math.Round(d2, 2)} nagyobb, mint {Math.Round(d1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(d2 - d1, 2)}");
            }
            Console.ReadKey();
        }
    }
}


```
