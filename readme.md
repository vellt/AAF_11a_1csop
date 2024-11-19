```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kiíratás, speciális karakterek
            
            // 1
            Console.WriteLine("\"Gipsz\t\tJakab\"");
            // 2
            Console.Write("\"udvozollek a programomba\"\n");
            // 3
            Console.WriteLine("\t- 2023.11.18. Ma megtanultam használni a speciális karaktereket C#-ban.");

            
            //-----------------------------------------------


            // Változók, érték bekérés, konvertálás

            // 1
            char karakter1 = Convert.ToChar(Console.ReadLine());
            char karakter2 = Convert.ToChar(Console.ReadLine());
            char karakter3 = Convert.ToChar(Console.ReadLine());
            char karakter4 = Convert.ToChar(Console.ReadLine());
            char karakter5 = Convert.ToChar(Console.ReadLine());
            Console.Write(karakter1);
            Console.Write(karakter2);
            Console.Write(karakter3);
            Console.Write(karakter4);
            Console.WriteLine(karakter5);
            // vagy
            Console.WriteLine($"{karakter1}{karakter2}{karakter3}{karakter4}{karakter5}"); // string interpoláció
            
            // 2
            bool logikai;
            Console.WriteLine("Adj meg egy logikai értéket: ");
            logikai = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(logikai);
            
            // 3
            string keresztnev = Console.ReadLine();
            string vezeteknev = Console.ReadLine();
            Console.WriteLine($"{vezeteknev} {keresztnev}"); // string interpoláció

            Console.ReadKey();
        }
    }
}


```