namespace ListaExercicios11
{
    internal class Program
    {
        //11. Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            int divisores = 0;

            Console.WriteLine("Insira um numero para verificarmos se ele é primo: ");
            int nPrimo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= nPrimo; i++)
            {
                if (nPrimo % i == 0 )
                 divisores++; 
            }

            if (divisores == 2)
            {
                Console.WriteLine($"O numero {nPrimo}, é primo!");
            }
        
            else
            {
                Console.WriteLine($"O numero {nPrimo}, não é primo!");
            }
        }

    }
}