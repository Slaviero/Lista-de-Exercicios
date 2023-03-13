using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;

namespace ListaExercicios15
{
    //Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
    //uma temperatura Celsius e imprima em Fahrenheit(pesquise como fazer este tipo de conversão).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em Celsisus: ");
            decimal tempCelsius = Convert.ToDecimal(Console.ReadLine());
            decimal tempFahrenheit = (tempCelsius * 9 / 5) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {tempFahrenheit}.");
        }
    }
}