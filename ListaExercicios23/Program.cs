using System.Runtime.Serialization.Formatters;

namespace ListaExercicios23
{
    //23. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 100; i < 200; i++) 
           {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
           }
        }
    }
}