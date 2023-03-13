using System;

namespace ListaExercicios09
{
    //9. Crie um programa para calcular a média harmônica das notas de um Aluno
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a sua segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a sua terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaHarm = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
            Console.WriteLine($"A sua média Harmonica é {mediaHarm = Math.Round(mediaHarm,2)}");

            Console.ReadLine();
        }
    }
}