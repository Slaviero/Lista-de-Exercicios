namespace ListaExercicios22
{
    //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo
    //na tela.
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            Console.Write("Insira o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine(c);
        }
    }
}