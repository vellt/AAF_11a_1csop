```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            // logikai kapuk: 
            // ÉS (AND): &&
            // VAGY (OR): ||
            // tagadás (NOT): !
            // döntsük el, hogy vehet-e valaki Legót
            Console.Write("Add meg a korod, megmondom vehetsz-e legót: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            if (kor>=6 && kor<=99) // és miatt mind a két feltételnek teljesülnie kell!
            {
                Console.WriteLine("Vehetsz Legót!");
            }
            else if (kor > 99)
            {
                Console.WriteLine("Te túl öreg vagy!");
            }
            else if (kor>=0 && kor<=5)// és miatt mind a két feltételnek teljesülnie kell!
            {
                Console.WriteLine("Túl fiatal vagy!");
            }
            else
            {
                Console.WriteLine("Ilyen nincs!");
            }

            // v2-es rövidítése a Legósnak
            if (kor >= 6 && kor <= 99) Console.WriteLine("Vehetsz Legót!");
            else if (kor > 99) Console.WriteLine("Te túl öreg vagy!");
            else if (kor >= 0 && kor <= 5) Console.WriteLine("Túl fiatal vagy!");
            else Console.WriteLine("Ilyen nincs!");

            // v3-as rövidítése a Legósnak, hámas operátorral
            Console.WriteLine((kor >= 6 && kor <= 99) ? "Vehetsz Legót!" : (kor > 99)? "Te túl öreg vagy!": (kor >= 0 && kor <= 5)? "Túl fiatal vagy!": "Ilyen nincs!");


            //--------------------------------------
            // Mi lehet az abszolút értéket számoló Math metódus mögött?
            // abszolút érték az, hogy -5-->5, 5-->5, tehát a minuszt leszedi!
            int abs = Math.Abs(-5); //5
            int abs2 = Math.Abs(5); //5

            int sz = -5;
            // v1-es megvalósítása az absz. érték algoritmizálására
            if (sz<0)
            {
                Console.WriteLine(sz+2*sz); // vagy sz*-1
            }
            else
            {
                Console.WriteLine(sz);
            }
            // v2-es rövidítése az absz. értéknek
            if (sz < 0) Console.WriteLine(sz + 2 * sz);
            else Console.WriteLine(sz);
            // v3 - hármas operátorral ugyan ez:
            Console.WriteLine((sz < 0) ? sz + 2 * sz : sz);
            

            //------------------------------------------
            // KŐ, PAPÍR, OLLÓ algoritmizálása
            
            Random r = new Random();
            int gep = r.Next(3);//[0,2]
            Console.Write("Válaszd ki a fegyvered (0-->kő, 1-->papír, 2-->olló): ");
            int felh = Convert.ToInt32(Console.ReadLine());
            // kiírjuk a gép mire gondolt, de szövegesen
            switch (gep)
            {
                case 0: Console.WriteLine("gép: kő"); break;
                case 1: Console.WriteLine("gép: papír"); break;
                default: Console.WriteLine("gép: olló"); break;
            }
            // kiírjuk a felhasználó mit választott, de szövegesen
            switch (felh)
            {
                case 0: Console.WriteLine("felhasználó: kő"); break;
                case 1: Console.WriteLine("felhasználó: papír"); break;
                default: Console.WriteLine("felhasználó: olló"); break;
            }

            // játék logika
            if (gep == 0 && felh == 2 ||
                gep == 1 && felh == 0 ||
                gep == 2 && felh == 1) 
            {
                Console.WriteLine("A gép nyert");
            }
            else if (gep == felh)
            {
                Console.WriteLine("Döntetlen");
            }
            else
            {
                Console.WriteLine("nyertél");
            }

            //--------------------------------------
            
            // szimuláljunk egy dobókocka dobást
            // és a generált dobást írjuk ki SZÖVEGESEN
            Random r2 = new Random();
            int dobokocka = r2.Next(6) + 1;
            switch (dobokocka)
            {
                case 1: Console.WriteLine("egy");break;
                case 2: Console.WriteLine("ketto");break;
                case 3: Console.WriteLine("három");break;
                case 4: Console.WriteLine("négy");break;
                case 5: Console.WriteLine("öt");break;
                case 6: Console.WriteLine("hat");break;
            }

            //------------------------------------------
            // Kérjünk be a felhasználótól egy hónapot
            // majd írjuk ki, milyen évszak van!
            Console.Write("Milyen hónap van? ");
            string honap = Console.ReadLine();
            // v1
            switch (honap.ToLower())
            {
                case "december": Console.WriteLine("tél"); break;
                case "január": Console.WriteLine("tél"); break;
                case "február": Console.WriteLine("tél"); break;
                case "március": Console.WriteLine("tavasz"); break;
                case "április": Console.WriteLine("tavasz"); break;
                case "május": Console.WriteLine("tavasz"); break;
                case "június": Console.WriteLine("nyár"); break;
                case "július": Console.WriteLine("nyár"); break;
                case "augusztus": Console.WriteLine("nyár"); break;
                case "szeptember": Console.WriteLine("ősz"); break;
                case "október": Console.WriteLine("ősz"); break;
                case "november": Console.WriteLine("ősz"); break;
            }
            // v2
            switch (honap.ToLower())
            {
                case "december": 
                case "január": 
                case "február":
                    Console.WriteLine("tél");
                    break;
                case "március":
                case "április":
                case "május":
                    Console.WriteLine("tavasz");
                    break;
                case "június": 
                case "július": 
                case "augusztus":
                    Console.WriteLine("nyár");
                    break;
                case "szeptember":
                case "október": 
                case "november":
                    Console.WriteLine("ősz");
                    break;
            }
            //---------------------------------------------------
            // RANDOM GYAKORLÁS

            Random r3 = new Random();
            // A NEXT-be ne kerüljön negatív szám!!!!!
            int sz1 = r3.Next(4) + 2; // [2,5]
            int sz2 = r3.Next(5) + 6; // [6,10]
            int sz3 = r3.Next(8) -2; // [-2,5]
            int sz4 = r3.Next(41) - 60; // [-60,-20]
            int sz5 = r3.Next(8); // [0,7]
            int sz6 = r3.Next(51); // [0,50]
            int sz7 = r3.Next(12) + 51; // [51,62]
            int sz8 = r3.Next(106) + 105; // [105,210]
            int sz9 = r3.Next(101)-50; // [-50,50]
            int sz10 = r3.Next(301)-100; // [-100,200]

            Console.ReadKey(); //<-- hogy ne záródjon be a program!
        }
    }
}

```