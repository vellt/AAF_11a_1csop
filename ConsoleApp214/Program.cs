using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp214
{
    class Adat
    {
        public int Helyezes { get; set; }
        public int SportolokSzama { get; set; }
        public string SportagNeve { get; set; }
        public string VersenyszamNeve { get; set; }

        public Adat(string sor)
        {
            string[] temp = sor.Split(' ');
            Helyezes = Convert.ToInt32(temp[0]);
            SportolokSzama = Convert.ToInt32(temp[1]);
            SportagNeve = temp[2];
            VersenyszamNeve = temp[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Adat> adatok = File.ReadAllLines("helsinki.txt")
                .Select(x=>new Adat(x)).ToList();

            int db = 0;
            for (int i = 0; i < adatok.Count(); i++)
            {
                if(adatok[i].Helyezes>=1 && adatok[i].Helyezes <= 6)
                {
                    db++;
                }
            }
            Console.WriteLine($"3. feladat: {db}");

            // 4
            int a=0, e=0, b=0; // a->arany, e->ezüst, b->bronz
            foreach (Adat adat in adatok)
            {
                if (adat.Helyezes == 1) a++;
                if (adat.Helyezes == 2) e++;
                if (adat.Helyezes == 3) b++;
            }
            Console.WriteLine($"Arany: {a}");
            Console.WriteLine($"ezüst: {e}");
            Console.WriteLine($"bronz: {b}");
            Console.WriteLine($"Összes: {a + e + b}");

            // 5
            int osszpont = 0;
            foreach (Adat adat in adatok)
            {
                switch (adat.Helyezes)
                {
                    case 1: osszpont += 7; break;
                    case 2: osszpont += 5; break;
                    case 3: osszpont += 4; break;
                    case 4: osszpont += 3; break;
                    case 5: osszpont += 2; break;
                    case 6: osszpont += 1; break;
                }
            }
            Console.WriteLine($"olimpiai pontok: {osszpont}");

            Console.ReadKey();
        }
    }
}
