using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            // A=pi*r^2
            Console.WriteLine("Kör sugara");
            double r = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(Math.Round(A,2));

            // Pitagorasz-tétel
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine(Math.Round(c,2));

            // első képlet
            Console.WriteLine("y");
            int y = Convert.ToInt32(Console.ReadLine());
            double eredmeny = Math.Sqrt(2 * y) + Math.Pow(2, 4);
            Console.WriteLine(Math.Round(eredmeny, 2));

            // masodik képlet
            Console.WriteLine("x");
            int x = Convert.ToInt32(Console.ReadLine());
            double eredmeny2 = Math.Pow(x * Math.PI, 1 / 3.0);
            Console.WriteLine(Math.Round(eredmeny2,2));

            // harmadik képlet
            // már korábban kértem be x-et és y-t ezért még egyszer nem fogok
            // csak felhasználom azt.
            double eredmeny3 = (3 * x - y) / (-5 * x + 3.0);
            Console.WriteLine(Math.Round(eredmeny3,2));

            Console.ReadKey();

        }
    }
}
