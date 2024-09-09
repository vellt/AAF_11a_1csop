```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaráció
            int a;
            // értékéadás
            a = 6;

            // definiálás(deklaráció + értékéadás)
            int sz1 = 6; // egész (szám) érték
            double sz2 = 3.7; // valós (szám) érték

            // egyszerű feltételvizsgálat
            if (sz1 > sz2)
            {
                Console.WriteLine("Az sz1 nagyobb");
            }else if (sz1 < sz2)
            {
                Console.WriteLine("Az sz2 nagyobb");
            }
            else // minden más eset
            {
                Console.WriteLine("Az sz1 és az sz2 egyenlő");
            }

            // elnevezési konvenciók
            string elsoVezeteknev = "alma"; //camelCase


            // egysoros komment
            // int h = null; 

            // többsoros komment
            /*
            kjdyhkfdsh
                ksjhsueh

                kjahku
                */

            // egyszerű adatbekérés, és a szöveges adat számmá való konvertálása
            Console.WriteLine("Add meg a korod:");
            string felh= Console.ReadLine();
            int kor = Convert.ToInt32(felh);
            if (kor>=18)
            {
                Console.WriteLine("beléphetsz a traffikba");
            }
            else
            {
                Console.WriteLine("nem léphetsz be");
            }


            // implicit konvertálás (kicsiből --> nagyba)
            int szam = 10;
            double szam2 = szam;

            // explicit (nagybol-->kicsibe)
            double sz = 2.6;
            int sz3 = (int)sz;
            

            // speciélis karakterek \ (vissza perjel)
            // \n új sor
            // \t tabulálás
            Console.WriteLine("Ez egy új sor karakter\n és egy tab: \t.");


            Console.WriteLine("adj meg egy szamot");
            string szoveg= Console.ReadLine();
            int szamom = Convert.ToInt32(szoveg);
            if (szamom % 2 == 0) // annak vizsgálata hogy a szám páros-e
            {
                Console.WriteLine($"páros: {a}"); // string interpoláció
            }
            else
            {
                Console.WriteLine($"páratlan: {a}");
            }

            
            int b = 7, c=9;
            Console.WriteLine($"ez egy szám: {b}, {c}");
            // alternatív string interpoláció
            Console.WriteLine("ez egy szám: {0}, {1}",b, c);
            Console.WriteLine("ez egy szám: " + b + ", " + c);

            Console.ReadKey(); // ez azért kell, hogy a program ne záródjon be!
        }
    }
}

```