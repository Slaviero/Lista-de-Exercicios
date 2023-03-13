using System.Data;
using System.Text;

namespace ListaExercicios05
{
    //5. Crie um programa para calcular o volume de uma esfera
    internal class Program
    {
        static void Main(string[] args)
        {
            double PI;
            PI = Math.PI;

            Console.Write("Informe o Raio de sua esfera: ");
            double raioEsfera = Convert.ToDouble(Console.ReadLine());

            double volEsfera = (4 * PI * (Math.Pow(raioEsfera, 3))) / 3 ;
            double volAredondado = Math.Round(volEsfera, 2);

            Console.WriteLine($"O volume de sua esfera é de {volAredondado} cm cubicos.");
            
            Console.ReadLine();
        }
    }
}