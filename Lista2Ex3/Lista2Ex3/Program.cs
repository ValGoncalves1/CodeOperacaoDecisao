using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite o primeiro valor ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor");
            c = int.Parse(Console.ReadLine());

            if (a == b)
                if (a == c)
                    Console.WriteLine("Iguais ");
                else
                    if (a > c)
                    Console.WriteLine("Primeiro/Segundo ");
                else
                    Console.WriteLine("Terceiro");

            else

            if (a == c)
                if (a > b)
                    Console.WriteLine("Primeiro e Terceiro  ");
                else
                    Console.WriteLine("Segundo ");

            else

                 if (b == c)
                if (b > a)
                    Console.WriteLine("Segundo / Terceiro ");
                else
                    Console.WriteLine("Primeiro ");

            else
                if (a > b)
                if (a > c)
                    Console.WriteLine("Primeiro ");
                else

                    Console.WriteLine("Terceiro ");

            else
                     if (b > c)

                Console.WriteLine("Segundo ");
            else
                Console.WriteLine("Terceiro ");

                
        }
    }
}
