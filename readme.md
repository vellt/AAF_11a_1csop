```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 --------------------------------------------------------
            Console.WriteLine("Adj meg egy számot és kiírom a 10szeresét");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * 10);
            
            // 2 --------------------------------------------------------
            Console.Write("Add meg az egyik számot: "); // Vajon mi a külöbség a Write és a WriteLine között??
            int sz1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a másik számot: ");
            int sz2 = Convert.ToInt32(Console.ReadLine());

            if (sz1 > sz2)
            {
                Console.WriteLine("Az első szám a nagyobb");
            }
            else if (sz1 == sz2) // két egyenlőség jel összehasonlítás, egy egyenlőség jel értékadás
            {
                Console.WriteLine("Egyenlőek");
            }
            else
            {
                Console.WriteLine("A második szám a nagyobb");
            }
            
            // 3 --------------------------------------------------------
            Console.WriteLine("Add meg a születési évedet:");
            int ev = Convert.ToInt32(Console.ReadLine());
            int kor = DateTime.Now.Year - ev; // 2024-et helyettesítettük a DateTime.Now.Year-el
            Console.WriteLine($"Te {kor} éves vagy.");

            if (kor<18) // 18 alatti
            {
                Console.WriteLine("Te még nem érettségiztél.");
            }
            else // 18 vagy feletti
            {
                Console.WriteLine("Te már érettségiztél.");
            }
            
            // 4 --------------------------------------------------------
            Console.WriteLine("Add meg a jelszót");
            string jelszo = Console.ReadLine(); // egy egyenlőség jel az értékadás

            if (jelszo == "jelszo123") // két egyenlőség jel összehasonlítás
            {
                Console.WriteLine("Helyes");
            }
            else
            {
                Console.WriteLine("Helytelen");
            }
            
            // 5 --------------------------------------------------------
            Console.WriteLine("add meg a jelszot: ");
            string jelszo = Console.ReadLine();
            int hossz = jelszo.Length; // bele rakjuk a hossz változóba a jelszó karakterhosszát
        
            if (hossz>10) //a hossz változó 10től nagyobb
            {
                Console.WriteLine("eros jelszo!");
            }
            else if (hossz<=10 && hossz >= 6) // ha a hossz változó 6 vagy a feletti, de 10 vagy az alatti szám
            {
                Console.WriteLine("közepes jelszo"); 
            }
            else
            {
                Console.WriteLine("gyenge jelszo"); // minden más eset, pl 1,2,3,4,5
            }
            
            // 6 --------------------------------------------------------
            Console.WriteLine("Add meg hány celsius fok van");
            int C= Convert.ToInt32(Console.ReadLine());

            int F = Convert.ToInt32(C*9/5.0+32); // osztási probléma --> osztáskor egyik tagja az osztásnak double legyen!
            Console.WriteLine($"F={F}");

            // 7 --------------------------------------------------------
            Console.WriteLine("Add meg az osztályzatot");
            int szam = Convert.ToInt32(Console.ReadLine());

            switch (szam)
            {
                case 1: Console.WriteLine("elégtelen"); break;
                case 2: Console.WriteLine("elégséges"); break;
                case 3: Console.WriteLine("közepes"); break;
                case 4: Console.WriteLine("jó"); break;
                case 5: Console.WriteLine("jeles"); break;
                default: Console.WriteLine("Ilyen osztályzat nincsen"); break; // minden más eset
            }

            // 8 --------------------------------------------------------
            Console.WriteLine("Adj meg egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 2 == 0) // a számot, ha modulózom 2-vel és az 0-t ad vissza, akkor az páros
            {
                Console.WriteLine("paros");
            }
            else
            {
                Console.WriteLine("paratlan"); // egyébként nem..
            }
            
            // 9 --------------------------------------------------------
            Console.WriteLine("Dobtam egy 7-es kockával, tippeld meg hogy hanyast dobtam.");
            int tipp = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int kocka = r.Next(7)+1; //[1,7]
            if (tipp == kocka)  // a tippben az van amennyi a kocka dobása
            {
                Console.WriteLine($"A szám amit dobtam: {kocka}. Gratulálok eltaláltad!");
            }
            else if (tipp > 7) // ha a tipp nagyobb mint 7
            {
                Console.WriteLine("7-nél nagyobb számot nem dobhattam.");
            }
            else if (tipp < 1) // ha a tippem 1től kisebb
            {
                Console.WriteLine("1-nél kisebb számot nem dobhattam.");
            }
            else // 1-7között tippeltem, de nem találtam el a kockadobást
            {
                Console.WriteLine($"A szám amit dobtam: {kocka}. Sajnos nem talált!");
            }

            // 10 --------------------------------------------------------
            Console.WriteLine("Adj meg egy számot");
            int nap = Convert.ToInt32(Console.ReadLine());

            switch (nap)
            {
                case 1: Console.WriteLine("hetfo"); break;
                case 2: Console.WriteLine("kedd"); break;
                case 3: Console.WriteLine("szerda"); break;
                case 4: Console.WriteLine("csutortok"); break;
                case 5: Console.WriteLine("pentek"); break;
                case 6: Console.WriteLine("szombat"); break;
                case 7: Console.WriteLine("vasarnap"); break;
                default: Console.WriteLine("1-7ig várok számot"); break; // miden más eset
            }
            
            // 11 --------------------------------------------------------
            // !!!!!!!!!!!!!!!!!osztási probléma bemutatása!!!!!!!!!!!!!!!!!!!
            Console.WriteLine(9/5); //-->1-et fog kiírni (mert az osztás mind2 tagja int!!!!), pedig 1,8-at kellene
            // ha már az osztás egyik tagja double, akkor jó eredményt mutat!
            // ÉRJÜK EL VALAHOGY, HOGY AZ EGYIK TAG DOUBLE LEGYEN.
            // TÖBB MÓDSZER IS VAN, PL
            Console.WriteLine(9/5.0); // 1,8
            Console.WriteLine(9/Convert.ToDouble(5)); // 1,8
            Console.WriteLine(9/(double)5); // 1,8
            
            // EZÉRT OSZTÁSKOR ÜGYELJÜNK, HOGY AZ OSZTÁS (LEGALÁBB) EGYIK TAGJA LEGYEN DOUBLE TÍPUSÚ!!!
            // EBBEN A FELADATBAN IS, MINT A CELSIUS-OSBAN .... VAN OSZTÁS...!
            
            Console.WriteLine("Adj meg egy számot");
            int sz1 = Convert.ToInt32(Console.ReadLine()); // STRING TO INT

            Console.WriteLine("Adj meg egy számot");
            int sz2 = Convert.ToInt32(Console.ReadLine()); // STRING TO INT

            Console.WriteLine("Adj meg egy műveletet");
            char muvelet = Convert.ToChar(Console.ReadLine()); // STRING TO CHAR
            // A CHAR EGY KARAKTER TÍPUS, KONKRÉTAN EGY KARAKTERT TUD TÁROLNI
            // PL 'A' 'B' '+' '2' '$' STB
            // ITT NEM ""(MACSKAKÖRÖM)-T HASZNÁLUNK HANEM ''(APOSZTRÓF)-T
            // 'A'-->CHAR TÍPUS
            // "A"--> STRING TÍPUS

            switch (muvelet)
            {
                case '+': Console.WriteLine(sz1 + sz2); break;
                case '-': Console.WriteLine(sz1 - sz2); break;
                case '*': Console.WriteLine(sz1 * sz2); break;
                case '/': Console.WriteLine(Math.Round(sz1 / Convert.ToDouble(sz2), 2)); break; // ÜGYELTÜNK AZ OSZTÁSRA, és kerekítettünk: Math.Round(double érték, kerekítés mértéke)
                case '%': Console.WriteLine(sz1 % sz2); break;
            }


        }
    }
}


```