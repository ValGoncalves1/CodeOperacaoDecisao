using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int base1;
            int altura;
            int área;

            Console.WriteLine("Digite o valor da área do retângulo:");
            base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do retangulo:");
            altura = int.Parse(Console.ReadLine());

            área = base1 * altura;

            if (área > 100)
                Console.WriteLine("Terreno grande.");
            else
                Console.WriteLine("Terreno pequeno:");
        }
    }
}
