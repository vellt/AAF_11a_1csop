using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp154
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[N];
            Random r = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(41) - 10; //[-10, 30]
            }

            // Állapítsd meg, hogy vajon a tömb értékei csökkenő sorrendben
            // generálódtak - e. [Eldöntés t.]
            bool vanEEE = true;
            for (int i = 1; i < tomb.Length && vanEEE==true; i++)
            {
                if (tomb[i-1]<tomb[i])
                {
                    vanEEE = false;
                }
            }
            Console.WriteLine(vanEEE?"Csökken mindig":"Nem csökken mindig");


            // Számoljuk meg, hogy mennyi 10 és 15 közötti van
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>10&&tomb[i]<15)
                {
                    db++;
                }
               
            }
            Console.WriteLine($"Ennyi 10 és 15 kközötti van{db}");

            // döntsük el, hogy minden elem 10 feletti-e
            bool vanEEEE = false;
            
            for (int i = 0; i < tomb.Length && vanEEEE==false; i++)
            {
                if (tomb[i]<=10)
                {
                    vanEEEE = true;
                    
                }
            }
            Console.WriteLine(vanEEEE? "nem" : "igen" );


            // van-e a tömbben 20 vagy 15-ös elem
            bool vanEE = false;
            for (int i = 0; i < tomb.Length && vanEE==false; i++)
            {
                if (tomb[i]==20 || tomb[i]==15 )
                {
                    vanEE = true;
                }
            }
            Console.WriteLine(vanEE? "van":"nincs");


            // hanyadik indexen található az első -5 szám

            int poz = -1;
            for (int i = 0; i < tomb.Length&&poz==-1; i++)
            {
                if (tomb[i]== -5   )
                {
                    poz = i;
                }
            }
            Console.WriteLine(poz);

            //  a tömb minden eleme egyforma??
            bool mindegyik = true;
            int minta = tomb[0];
            for (int i = 0; i < tomb.Length && mindegyik==true; i++)
            {
                if (tomb[i]!=minta)
                {
                    mindegyik = false;
                }
            }
            Console.WriteLine(mindegyik?"igen":"nem");

            Console.ReadKey();
        }
    }
}
