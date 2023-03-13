namespace ListaExercicios01
{
    //1. Crie um programa para calcular o volume de uma caixa retangular
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a base de sua caixa: ");
            double baseCaixa = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Informe a altura de sua caixa: ");
            double alturaCaixa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a largura de sua caixa: ");
            double larguraCaixa = Convert.ToDouble(Console.ReadLine());

            double volume;
            volume = baseCaixa * alturaCaixa * larguraCaixa;

            Console.WriteLine($"O volume de sua caixa é {volume}.");
            Console.ReadLine();
        }
    }
}