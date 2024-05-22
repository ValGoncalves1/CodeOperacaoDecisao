using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex6
{
    internal class Program
      
    {
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o peso da pessoa (em kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura da pessoa (em metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());

              
                double imc = peso / (altura * altura);

                
                if (imc < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (imc < 25)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
        }
    }

}


