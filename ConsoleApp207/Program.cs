using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Koszones());
            Console.WriteLine(Koszones("Béla!"));
            Console.WriteLine(Legnagyobb(7,9,5));

            int[] tomb = new int[] { 1, 2, 3, 5, 6 };
            Console.WriteLine(Legnagyobb(tomb));

            List<int> lista = new List<int>() { 1, 3, 4, 6, 10 };
            Console.WriteLine(Legnagyobb(lista));
            Console.ReadKey();
        }
        static int Legnagyobb(List<int> lista)
        {
            int max = lista[0];
            for (int i = 1; i < lista.Count(); i++)
            {
                if (max<lista[i])
                {
                    max = lista[i];
                }
            }
            return max;
        }

        static int Legnagyobb(int[] tomb)
        {
            int max = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[i];
                }
            }
            return max;
        }

        static int Legnagyobb(int szam1, int szam2, int szam3)
        {
            int max = szam1;
            if (max < szam2)
            {
                max = szam2;
            }
            if(max < szam3)
            {
                max = szam3;
            }
            return max;
        }
        // saját függvény
        static string Koszones()
        {
            return "Szia Ottó!";
        }

        static string Koszones(string nev)
        {
            return $"Szia {nev}!";
        }
    }
}
