using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp213
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista--> dinamikus
            // tömb---> statikus, nem tud kisebb nagyobb lenni

            List<string> nevek = new List<string>(); // 4 elemű
            nevek.Add("Béla");
            nevek.Add("Béla");
            nevek.Add("Cecil");
            nevek.Add("Árpád");

            // mennyi az elemeinek a száma
            Console.WriteLine(nevek.Count()); // 4

            // hanyadik indexen van Béla
            Console.WriteLine(nevek.IndexOf("Béla"));

            // van-e benne Árpád
            bool van = nevek.Contains("Árpád");
            Console.WriteLine(van ? "van" : "nincs");

            // ábécé sorrend
            nevek.Sort(); // ábécébe rendezi
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            nevek.Reverse(); // csökkenő sorrend
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            nevek.Remove("Béla"); // az összes előfordulást eltávolítja
            nevek.RemoveAt(0); // egy indexet/elemet távolít el

            foreach (string nev in nevek.Distinct())
            {
                Console.WriteLine(nev);
            }

            Console.ReadKey();
        }
    }
}
