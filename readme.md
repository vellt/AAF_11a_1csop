```csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class csop1
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Add meg az a értékét: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a b értékét: ");
            b = Convert.ToInt32(Console.ReadLine());

            int osszeg = a + b;
            int kulombeseg = a - b;

            Console.WriteLine($"Összegük: {osszeg}");
            Console.WriteLine($"Külömbségük: {kulombeseg}");

            // -------------------------------------------------
            
            int a, b;

            Console.Write("Add meg a erteket: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a erteket: ");
            b = Convert.ToInt32(Console.ReadLine());

            int szorzat = a * b;
            double hanyados = a / (double)b;

            Console.WriteLine($"szorzatuk: {szorzat}");
            Console.WriteLine($"hanyados: {hanyados}");*/
            
            // -------------------------------------------------

            int F, C;

            Console.Write("Add meg mennyi c van: ");
            C = Convert.ToInt32(Console.ReadLine());

            F = (int)(C * 9 / (double)5 + 32);

            Console.WriteLine($"F: {F}");
            
            // -------------------------------------------------

            int C, F;

            Console.Write("Add meg hány F van: ");
            F = Convert.ToInt32(Console.ReadLine());

            C = (int)((F - 32) * (5.0 / 9.0));

            Console.WriteLine($"C:{C}");

            // -------------------------------------------------

            double K, T, a, b;

            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Add meg az 'b' értékét: ");
            b = Convert.ToDouble(Console.ReadLine());

            K = 2 * (a + b);
            T = a * b;

            Console.WriteLine($"Ennyi a kerülete {Math.Round(K,2)}");
            Console.WriteLine($"Ennyi a területe {T:0.00}");
            
            // -------------------------------------------------


            double A, V, a;

            Console.Write("add meg a negyzet hosszat: ");
            a = Convert.ToDouble(Console.ReadLine());

            A = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);

            Console.WriteLine($"A: {A:0.00}");
            Console.WriteLine($"V: {Math.Round(V,2)}");

            // -------------------------------------------------
            
            double a, b, c, A, V;
            
            Console.Write("Add meg az 'a' értéket: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az 'b' értéket: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az 'c' értéket: ");
            c = Convert.ToDouble(Console.ReadLine());

            A = 2 * a * b + 2 * a * c + 2 * b * c;
            V = a * b * c;

            Console.WriteLine($"A téglatest felülete: {Math.Round(A,4)}");
            Console.WriteLine($"A téglatest térfogata: {Math.Round(V,4)}");
            
            // -------------------------------------------------

            double r,m, A, V;

            Console.Write("Add meg az 'r' értékét");
            r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg az 'm' értékét");
            m = Convert.ToInt32(Console.ReadLine());

            A = Math.PI * r * m;
            V = 2 * Math.PI * r * (r + m);

            Console.WriteLine($"A felszíne: {Math.Round(A,4)}");
            Console.WriteLine($"A térfogata: {V:0.0000}");
            
            // -------------------------------------------------
            // ilyen jellegű feladatra NEM kell számítani, véletlenül jött elő
            // viszont akit érdekel a megoldása, itt lesz:
            Console.Write("Adj meg egy oszeget: ");
            string osszeg = Console.ReadLine();
            char utolsoKarakter = osszeg[osszeg.Length - 1];
            int maradek = Convert.ToInt32(utolsoKarakter.ToString()) % 5;
            if (maradek == 0)
            {
                Console.WriteLine(osszeg);
            }
            else if (maradek>= 3)
            {
                Console.WriteLine(Convert.ToInt32(osszeg)+(5-maradek));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(osszeg) - (maradek));
            }
            
            // -------------------------------------------------

            int szam1;

            Console.WriteLine("adj egy számot");
            szam1 = Convert.ToInt32(Console.ReadLine());

            if (szam1%2==0)
            {
                Console.WriteLine("Ez egy páros szám");
            }
            else
            {
                Console.WriteLine("Ez egy páratlan szám");
            }
            
            // -------------------------------------------------
            
            int szam1;

            Console.WriteLine("Adj meg egy számot");
            szam1 = Convert.ToInt32(Console.ReadLine());

            if (szam1==0)
            {
                Console.WriteLine("ez a szám 0");
            }
            else if (szam1%2!=0)
            {
                Console.WriteLine("ez egy páratlan szám");
            }
            else
            {
                Console.WriteLine("ez a szám páros");
            }

            // -------------------------------------------------

            Console.Write("Adj meg egy tetszőleges számot: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n%3==0)
            {
                Console.WriteLine("Ez a szám osztható 3-al (maradék nélkül)");
            }
            else
            {
                Console.WriteLine("Nem osztható 8-al (maradék nélkül)");
            }
            
            // -------------------------------------------------

            Console.Write("adj meg egy szamot! ");
            int szam1 = Convert.ToInt32(Console.ReadLine());

            if (szam1==1)
            {
                Console.WriteLine("hetfo");
            }
            else if (szam1==2)
            {
                Console.WriteLine("kedd");
            }
            else if (szam1==3)
            {
                Console.WriteLine("szerda");
            }
            else
            {
                Console.WriteLine("ilyen opci nincs!!");
            }
            
            // -------------------------------------------------

            Console.WriteLine("Add meg a focicsapat pontszámát");
            int pontszam = Convert.ToInt32(Console.ReadLine());

            if (pontszam == 0)
            {
                Console.WriteLine("A csapat vereséget szenvedett");
            }
            else if (pontszam == 1)
            {
                Console.WriteLine("A focicsapat döntetlent játszott");
            }
            else if (pontszam == 3)
            {
                Console.WriteLine("A csapat győzött");
            }

            Console.ReadKey(); // azért kell, hogy a program mikor lefut ne záródjon be
        }
    }
}

```
