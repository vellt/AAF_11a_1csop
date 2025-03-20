using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp162
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek= File.ReadAllLines("nevek.txt");

            int index = -1;
            for (int i = 0; i < nevek.Length && index==-1; i++)
            {
                if (nevek[i]=="Körte Vilmos")
                {
                    index = i;
                }
            }
            if (index==-1)
            {
                Console.WriteLine("Nincs Vilmos Körte a nevek között");
            }
            else
            {
                Console.WriteLine($"Van: {index+1}. helyen");
            }

            bool van = false;
            for (int i = 0; i < nevek.Length && van==false; i++)
            {
                string nev = nevek[i];
                char elsoKarakter = nev[0];
                char utolsoKarakter = nev[nev.Length - 1];
                if (elsoKarakter==utolsoKarakter)
                {
                    van = true;
                }
            }
            Console.WriteLine(van ? "van" : "nincs");

            bool van2 = false;
            for (int i = 0; i < nevek.Length && van2==false; i++)
            {
                string vezeteknev = nevek[i].Split(' ')[0];
                if (vezeteknev=="Sunyi")
                {
                    van2 = true;
                }
            }
            Console.WriteLine(van2 ? "van" : "nincs");



            Console.ReadKey();
        }
    }
}
