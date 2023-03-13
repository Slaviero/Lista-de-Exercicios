using System.Drawing;
using System.Runtime.Intrinsics.X86;
namespace ListaExercicios25
{
//    Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.Mostre a
//tabuada na forma:
// 0 x N = 0,
// 1 x N = 1N,
// 2 x N = 2N,
//.
//.
//.
// 10 x N = 10N.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor para gerar tabuada: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=10; i++) 
            {
                int tabuada = i * valor;
                Console.WriteLine($"{i} X {valor} = {tabuada}");
            }
        }
    }
}