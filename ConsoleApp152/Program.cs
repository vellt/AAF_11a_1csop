using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a tömb hosszát: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[n];
            Random r = new Random();
            // töltsük fel a [-10,50]-ban
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(61) - 10;
            }

            // összegzés tétele
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine(osszeg);

            // átlag
            double atlag = osszeg / (double)tomb.Length;
            Console.WriteLine(Math.Round(atlag,2));

            // Van-e 20-as a tömbben? [Eldöntés tétele]
            bool vanE = false;
            for (int i = 0; i < tomb.Length && vanE==false; i++)
            {
                if (tomb[i]==20)
                {
                    vanE = true;
                }
            }
            Console.WriteLine(vanE?"igen":"nem");

            // Hányadik helyen/indexen van a 6-os a tömbben? [Kiválasztás t]
            int index = -1;
            for (int i = 0; i < tomb.Length && index==-1; i++)
            {
                if (tomb[i]==6)
                {
                    index = i;
                }
            }
            if (index==-1)
            {
                Console.WriteLine("nincs a tömbben 6-os");
            }
            else
            {
                Console.WriteLine($"{index+1}. helyen van a {tomb[index]}");
            }

            // Állapítsd meg, hogy van-e benne 3-mal osztható szám [Eldöntés t.]

            bool vanEE = false;
            for (int i = 0; i < tomb.Length && vanEE==false; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    vanEE = true;
                }
            }
            Console.WriteLine(vanEE ? "igen" : "nem");

            // Állapítsd meg, hogy vajon van-e a tömbben 2 és 10 közötti érték.
            // [Eldöntés t.]
            bool vanEEE = false;
            for (int i = 0; i < tomb.Length && vanEEE==false; i++)
            {
                if (tomb[i]>2 && tomb[i]<10)
                {
                    vanEEE = true;
                }
            }
            Console.WriteLine(vanEEE?"igen":"nem");

            // Állapítsd meg, hogy vajon a tömb minden eleme pozitív-e. [Eldöntést.]
            bool vanEEEE = true;
            for (int i = 0; i < tomb.Length && vanEEEE == true; i++)
            {
                if (tomb[i] < 0)
                {
                    vanEEEE = false;
                }
            }
            Console.WriteLine(vanEEEE?"igen":"nem");

            // Állapítsd meg, hogy vajon a tömb minden eleme 5-el osztható-e.
            // [Eldöntés t.]
            bool mindegyik = true;
            for (int i = 0; i < tomb.Length && mindegyik==true; i++)
            {
                if (tomb[i] % 5 != 0)
                {
                    mindegyik = false;
                }
            }
            if (mindegyik)
            {
                Console.WriteLine("mindegyik 5-el osztható");
            }
            else
            {
                Console.WriteLine("NEM is mindegyik 5-el osztható");
            }

            // Állapítsd meg, hogy vajon minden második eleme a tömbnek
            // egyforma - e. [Eldöntés t.]
            bool mindegyik2 = true;
            int egyezes = tomb[0];
            for (int i = 0; i < tomb.Length && mindegyik2==true; i+=2)
            {
                if (tomb[i]!=egyezes)
                {
                    mindegyik2 = false;
                }
            }
            Console.WriteLine(mindegyik2?"igen":"nem minden második egyforma");

            // Állapítsd meg, hogy vajon az első és utolsó eleme a tömbnek
            // egyforma - e. [Eldöntés t.]
            int elso = tomb[0];
            int utolso = tomb[tomb.Length - 1];
            if (elso==utolso)
            {
                Console.WriteLine("egyezik");
            }
            else
            {
                Console.WriteLine("nem egyezik");
            }

            Console.ReadKey();
        }
    }
}
