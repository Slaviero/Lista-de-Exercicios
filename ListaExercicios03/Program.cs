using System.Transactions;

namespace ListaExercicios03
{
    //3. Crie um programa para calcular o volume de um Cilindro
    internal class Program
    {
        static void Main(string[] args)
        {
            double volCilindro;
            double PI;
            PI = (double)Math.PI;
            
            Console.Write("Informe o Raio do seu Cilindro: ");
            double raioCilindro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o Altura do seu Cilindro: ");
            double alturaCilindro = Convert.ToDouble(Console.ReadLine());

            volCilindro = PI * Math.Sqrt(raioCilindro) * alturaCilindro;

            Console.WriteLine($"O volume de seu cilindro é de {volCilindro}");
            Console.ReadLine();
        }
    }
}   