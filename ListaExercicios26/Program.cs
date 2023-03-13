using System.Drawing;

namespace ListaExercicios26
{
//    Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
//resultado.
//a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//b.Pesquise sobre “fatorial”
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = x-1; i > 0; i--)
            {
                x = x * i;
            }
            Console.WriteLine($"O resultado de sua operação é {x}.");
        }
    }
}