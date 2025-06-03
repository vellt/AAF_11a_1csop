using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    enum Muvelet { Osszeadas, Kivonas, Szorzas, Osztas }
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            double osszeg = ZsebSzamologep(a, b, 'ü');
            Console.WriteLine(osszeg);
            double osszeg2 = ZsebSzamologep(a, b, Muvelet.Osztas);
            Console.WriteLine(osszeg2);
            Console.WriteLine(TeljesNev("Nagy","Balazs"));
            Console.WriteLine(TeljesNev("Tóth","Béla"));
            // gömb térfogat
            Console.WriteLine(GombTerfogat(6.89));
            // téglalap terület
            Console.WriteLine(TeglalapTerulete(55,77));
            // 7^3
            Console.WriteLine(Hatvany(7, 3));
            // páros vagy páratlan
            Console.WriteLine(Paros(7) ? "páros" : "páratlan");
            Console.ReadKey();
        }

        static bool Paros(int n)
        {
            return n % 2 == 0;
        }

        static double Hatvany(int alap, int kitevo)
        {
            return Math.Pow(alap, kitevo);
        }

        static double TeglalapTerulete(double a, double b)
        {
            double eredmeny = 2 * (a + b);
            return eredmeny;
        }

        static double GombTerfogat(double r)
        {
            double eredmeny = (4 * Math.Pow(r, 3) * Math.PI) / 3;
            return eredmeny;
        }


        static string TeljesNev(string veznev, string kernev)
        {
            return $"{veznev} {kernev}";
        }

        static double ZsebSzamologep(int a, int b, Muvelet muvelet)
        {
            double eredmeny = 0;
            switch (muvelet)
            {
                case Muvelet.Osszeadas: eredmeny = a + b; break;
                case Muvelet.Kivonas: eredmeny = a - b; break;
                case Muvelet.Szorzas: eredmeny = a * b; break;
                case Muvelet.Osztas: eredmeny = a / b; break;
            }
            return eredmeny;
        }

        static double ZsebSzamologep(int a, int b, char muvelet)
        {
            double eredmeny = 0;
            switch (muvelet)
            {
                case '+': eredmeny = a + b; break;
                case '-': eredmeny = a - b; break;
                case '*': eredmeny = a * b; break;
                case '/': eredmeny = a / b; break;
                case '%': eredmeny = a % b; break;
            }
            return eredmeny;
        }
    }
}
