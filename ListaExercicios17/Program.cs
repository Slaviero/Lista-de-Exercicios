namespace ListaExercicios17
{
    //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C.");
            }
        }
    }
}