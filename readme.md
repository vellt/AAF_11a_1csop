```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // primitív típusok
            // stack-->gyors
            // nem lehet null értékű
            int egeszSzam = 12;
            double valosSzam = 3.5;
            bool logikaiTipus = true; // false
            char karakterTipus = 'a';

            // referencia típus
            // heap-->lassabb
            // tartalmazhat null értéket
            string szovegesAdat = "alma";
            char elsoKarakter= szovegesAdat[0]; // szöveges adat első eleme
            char utolsoKarakter = szovegesAdat[szovegesAdat.Length-1]; // szöveges adat utolsó eleme
            char[] karakterTomb = { 'a', 'l', 'm', 'a' }; // karakter tömb
            int[] intTomb = { 1, 2, 3 }; // int tömb

            //------------------------------------------------------
            /*
             több
             soros 
             komment
             */

            //------------------------------------------------------

            // definiálás
            int h = 12; // deklaráció + értékadás

            // deklaráció
            int u;
            // érétkadás
            u = 5;

            //------------------------------------------------------

            // konvertálás (pl string-->int)
            int sz = Convert.ToInt32("5");
            // implicit konvertálás (kicsiből --> nagyba) (pl int-->double)
            double sz2 = 6;
            // explicit konvertáció / kasztolás (nagyból-->kicsibe) (pl double-->int)
            int sz3 = (int)22.6;


            //------------------------------------------------------


            // konzolkezelés 
            // kiíratás, adatbekérés, konvertálás, if
            Console.WriteLine("Add meg az egyik számot: ");
            int egyikSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a másik számot: ");
            int masikSzam = Convert.ToInt32(Console.ReadLine());
            if (egyikSzam<masikSzam)
            {
                Console.WriteLine($"második({masikSzam}) a nagyobb"); //második(6) a nagyobb
            }
            else if(egyikSzam>masikSzam)
            {
                Console.WriteLine($"Első({elsoKarakter}) a nagyobb"); // Első(6) a nagyobb
            }
            else
            {
                Console.WriteLine("A két szám egyforma");
            }

            //------------------------------------------------------

            // konzolkezelés
            // kiíratás, bekérés, konvertálás, if
            Console.WriteLine("BARKÓBA");
            Console.WriteLine("Tippelj egy számra (1-5)");
            int tipp = Convert.ToInt32(Console.ReadLine());
            int gep = 4;
            if (tipp==gep)
            {
                Console.WriteLine("Igen. Ez az amire én gondoltam");
            }
            else
            {
                Console.WriteLine("Nem erre gondoltam");
                Console.WriteLine($"Amire én gondoltam az a(z): {gep}");
            }

            //------------------------------------------------------


            // szamolás
            // osztásnál figyelni!
            // legalább az egyik tag double legyen!
            // hogy kapjunk az eredményben tizedeseket!
            int a = 2, b = 6;
            int osszeadas = a + b;
            int kivonas = a - b;
            int szorzas = a * b;
            double osztas = a / (double)b;
            Console.WriteLine($"{a}+{b}={osszeadas}");
            Console.WriteLine($"{a}-{b}={kivonas}");
            Console.WriteLine($"{a}*{b}={szorzas}");
            Console.WriteLine($"{a}/{b}={osztas:0.00}"); // kerekítés :0.00
            Console.WriteLine($"{a}/{b}={Math.Round(osztas, 2)}"); // kerekítés Math.Round(ertek,tizedes)
            Console.WriteLine(2.0/Convert.ToDouble(6)); // sok módszer van arra, hogy egy int double legyen!


            //------------------------------------------------------


            // Math osztályok alkalmazása

            /*
             Math.Round(valosSzam,Kerekites)- kerekítés
             Math.Sqrt(akarmilyenSzam) - négyzetgyökvonás
             Math.Pow(alap,kiveto) - hatványozás
             Math.PI - pi értéke
             */

            Console.WriteLine("1. feladat");
            int alap, kitevo; // szükséges változók deklarálása
            Console.WriteLine("Add meg az alapot: ");
            alap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a kivetőt: ");
            kitevo = Convert.ToInt32(Console.ReadLine());

            // kiszámítjuk a bekért értékekkel a hatványt
            double hatvany= Math.Pow(alap, kitevo);
            Console.WriteLine(hatvany); // kiírjuk az eredményt
            // A hatványozás eredményét négyzetgyök alá tesszük
            double negyzet = Math.Sqrt(hatvany);
            Console.WriteLine(Math.Round(negyzet,2)); // az eredmény 2 tizedes pontosan


            //------------------------------------------------------

            Console.WriteLine("2. feladat");
            double r, K, T; // szükséges változók deklarálása
            Console.WriteLine("Add meg a kör sugarát");
            r = Convert.ToDouble(Console.ReadLine());

            // terület, kerület kiszámítása, miután már tudjuk a kör sugarát
            K = 2 * r * Math.PI;
            T = r * r * Math.PI;
            // kiíratjuk kerekítve az eredményt
            Console.WriteLine($"K: {Math.Round(K,2)}");
            Console.WriteLine($"T: {Math.Round(T,2)}");

            //------------------------------------------------------

            // HF: MF 27/1,2,3 feladat



            Console.ReadKey(); // azért h ne záródjon be a program ha lefutott
        }
    }
}
```