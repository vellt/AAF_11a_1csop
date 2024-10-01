```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mintadoga
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());


            double szam1, szam2;

            // a
            szam1 = 1.8 * Math.Pow(x, 3);
            szam2 = 1.8 * Math.Pow(y, 4);
            if (szam1 > szam2)
            {
                Console.WriteLine($"a) {Math.Round(szam1, 2)} nagyobb, mint {Math.Round(szam2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam1 - szam2, 2)}");
            }
            else
            {
                Console.WriteLine($"a) {Math.Round(szam2, 2)} nagyobb, mint {Math.Round(szam1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam2 - szam1, 2)}");
            }

            // b
            szam1 = Math.Pow(x, 1 / 31.0);
            szam2 = Math.Pow(y, 1 / 7.0);
            if (szam1 > szam2)
            {
                Console.WriteLine($"b) {Math.Round(szam1, 2)} nagyobb, mint {Math.Round(szam2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam1 - szam2, 2)}");
            }
            else
            {
                Console.WriteLine($"b) {Math.Round(szam2, 2)} nagyobb, mint {Math.Round(szam1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam2 - szam1, 2)}");
            }

            // c
            szam1 = ((double)x / 4) / (5.0 / y);
            szam2 = 2 * (Math.Pow(x, 2) - (y / 3.0));
            if (szam1 > szam2)
            {
                Console.WriteLine($"c) {Math.Round(szam1, 2)} nagyobb, mint {Math.Round(szam2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam1 - szam2, 2)}");
            }
            else
            {
                Console.WriteLine($"c) {Math.Round(szam2, 2)} nagyobb, mint {Math.Round(szam1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam2 - szam1, 2)}");
            }

            // d
            szam1 = (2.5+x*Math.Pow(y,2)) / (2*x+y);
            szam2 = Math.PI;
            if (szam1 > szam2)
            {
                Console.WriteLine($"d) {Math.Round(szam1, 2)} nagyobb, mint {Math.Round(szam2, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam1 - szam2, 2)}");
            }
            else
            {
                Console.WriteLine($"d) {Math.Round(szam2, 2)} nagyobb, mint {Math.Round(szam1, 2)}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(szam2 - szam1, 2)}");
            }

            Console.ReadKey();

        }
    }
}

```