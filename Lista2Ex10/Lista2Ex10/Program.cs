using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o peso da pessoa em kg:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da pessoa em metros:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        double imc = CalcularIMC(peso, altura);

        Console.WriteLine($"O IMC da pessoa é: {imc}");

        if (sexo == 'M')
        {
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {