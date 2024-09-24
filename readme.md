```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az 'a' értékét: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a 'b' értékét: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"c értéke: {Math.Round(c, 2)}");
            
            // ----------------------------------------------------
            
            double a, b;
            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az 'b' értékét: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (b==0)
            {
                Console.WriteLine("0-val nem lehet osztani");
            }
            else
            {
                Console.WriteLine($"{a}/{b}={Math.Round(a/b,2)}");
            }

            // ----------------------------------------------------

            double a, b;
            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az 'b' értékét: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine($"{a}/{b}={Math.Round(a / b, 2)}");
            }
            else
            {
                Console.WriteLine($"{b}/{a}={Math.Round(b / a, 2)}");
            }

            // ----------------------------------------------------

            double a, b, c;

            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a 'b' értékét: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a 'c' értékét: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a+b>c && c+b>a && a+c>b)
            {
                Console.WriteLine("Szerkeszthető a 3szög");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető 3szög");
            }
            
            // ----------------------------------------------------

            int a, b;
            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg az 'b' értékét: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>0 && b>0)
            {
                Console.WriteLine("Az első siknegyedben vagyunk");
            }
            else if (a<0 && b>0)
            {
                Console.WriteLine("A második siknegyedben vagyunk");
            }
            else if (a< 0&& b<0 )
            {
                Console.WriteLine("A harmadikban vagyunk");
            }
            else if (a>0 && b<0)
            {
                Console.WriteLine("A negyedikben vagyunk");
            }
            else
            {
                Console.WriteLine("origo");
            }

            // ----------------------------------------------------
            
            Console.Write("add meg a pont számot: ");
            int pontszam = Convert.ToInt32(Console.ReadLine());
            int szazalek = (int)Math.Round((pontszam / 150.0)*100);

            if (szazalek>=0 && szazalek<=19)
            {
                Console.WriteLine("Elégtelen (1)");
            }
            else if (szazalek>=20 && szazalek<=39)
            {
                Console.WriteLine("Eléséges (2)");
            }
            else if (szazalek>=40 && szazalek<=59)
            {
                Console.WriteLine("Kozepes (3)");
            }
            else if (szazalek >= 60 && szazalek <= 79)
            {
                Console.WriteLine("jo (4)");
            }
            else
            {
                Console.WriteLine("jeles (5)");
            }

            Console.ReadKey(); // azért kell, hogy a program ne záródjon be
        }
    }
}


```