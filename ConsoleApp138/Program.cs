using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp138
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gyumolcsok = File.ReadAllLines("gyumolcsok.csv");

            // adatok kiíratása
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                Console.WriteLine(gyumolcsok[i]);
            }

            // megszámlálás: mennyi a betűvel kezdődő van
            int db = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                string gyumolcs = gyumolcsok[i];
                if (gyumolcs[0]=='A')
                {
                    db++;
                }
            }
            Console.WriteLine(db);

            // min/max: A legrövidebb nevű gyümölcsöt
            int minHossz = gyumolcsok[0].Length;
            for (int i = 1; i < gyumolcsok.Length; i++)
            {
                if (gyumolcsok[i].Length<minHossz)
                {
                    minHossz = gyumolcsok[i].Length;
                }
            }
            Console.WriteLine(minHossz);

            // összegzés: összkarakterhossz
            int ossz = 0;
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                ossz += gyumolcsok[i].Length;
            }
            Console.WriteLine(ossz);

            // eldöntés tétele: igaz/hamis választ vár. 
            // van-e benne körte
            // (összetett bennmaradási feltételt használ: gyumolcsok.Length && vanE==false
            // mindkettőre szükség van, hogy a ciklus ismétlődjön, azért van &&-el összekapcsolva, 
            // plusz azt érjük el vele, ha már megtalálta a keresett elemet, elhagyja a ciklust, nem ismétlődik)
            bool vanE = false;
            for (int i = 0; i < gyumolcsok.Length && vanE==false; i++)
            {
                if (gyumolcsok[i]=="körte")
                {
                    vanE = true;
                }
            }
            Console.WriteLine(vanE?"van":"nincs");

            // van-e olyan gyümölcs, aminek az első karaktere 'B'
            bool vanE2 = false;
            for (int i = 0; i < gyumolcsok.Length && vanE2==false; i++)
            {
                if (gyumolcsok[i][0]=='B')
                {
                    vanE2 = true;
                }
            }

            if (vanE2)
            {
                Console.WriteLine("Talált benne.");
            }
            else
            {
                Console.WriteLine("nem találtunk benne.");
            }
           
            Console.ReadKey();

        }
    }
}
