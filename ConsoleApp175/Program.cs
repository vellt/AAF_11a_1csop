using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp175
{
    class Program
    {
        static void Main(string[] args)
        {
            // írjuk ki, nézzük meg mit ad vissza
            int sz1 = 65;
            int sz2 = 76;
            int sz3 = 77;
            int sz4 = 65;
            Console.WriteLine($"{sz1} {sz2} {sz3} {sz4}");
            
            // és most?
            Console.WriteLine($"{(char)sz1} {(char)sz2} {(char)sz3} {(char)sz4}");
            
            // B-betű 
            Console.WriteLine((char)66);
            
            // ABC kiíratása
            for (int i = 65; i <= 90; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
            
            // Fordított ABC kiírása
            for (int i = 90 ; i >= 65; i--)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();

            // mennyi a kódja a kis 'a'-nak?
            Console.WriteLine((int)'a'); // 97
            // és a nagy 'A'-nak?
            Console.WriteLine((int)'A'); // 65

            // a kis a-->97, a nagy A-->65. A diff: 32
            // tehát ha nagyból akarok kisbetűt: nagybetű+32=kisbetű
            // ha kicsiből akarok nagybetűt: kisbetű-32=nagybetű
            Console.WriteLine($"{'A'}-->{(char)('A'+32)}"); // A-->a
            Console.ReadKey();
        }
    }
}
