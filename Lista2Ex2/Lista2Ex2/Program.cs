using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Digite o Primeiro valor ");
            a = int .Parse(Console.ReadLine());
            Console.Write("Digite o Segundo ");
            b = int .Parse(Console.ReadLine());

            if (a == b)

                Console.WriteLine("Igual");

            else

            if
                (a > b)

                Console.WriteLine("Primeiro");

            else

                Console.WriteLine("Segundo");

            
        }
    }
}
