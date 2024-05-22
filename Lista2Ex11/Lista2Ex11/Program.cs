using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota da primeira avaliação (P1):");
        double notaP1 = double.Parse(Console.ReadLine());

        double mediaDesejada = 5;

        double notaP2Necessaria = CalcularNotaP2Necessaria(notaP1, mediaDesejada);

        Console.WriteLine($"Para ser aprovado, você precisa tirar pelo menos {notaP2Necessaria} na segunda avaliação (P2).");
    }

    static double CalcularNotaP2Necessaria(double notaP1, double mediaDesejada)
    {
        return (mediaDesejada * 2) - notaP1;
    }
}