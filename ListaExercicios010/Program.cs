namespace ListaExercicios010
{
    //10. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a primeira nota: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());


            decimal mediaPonderada = ((nota1 * 5) + (nota2 * 5)) / 5 + 5 ;
            Console.WriteLine($"Sua média ponderada é: {mediaPonderada}.");
        }
    }
}