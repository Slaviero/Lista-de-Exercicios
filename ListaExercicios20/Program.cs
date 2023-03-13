namespace ListaExercicios20
{
    //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero qualuqer: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O numero {numero} é par!");
            }
            else
            {
                Console.WriteLine($"O numero {numero} não é par.");
            }
        }
    }
}