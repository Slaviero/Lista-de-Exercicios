namespace ListaExercicios14
{
    /*Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Qual a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasDeVida = idade * 365;
            Console.WriteLine($"{nome} você viveu {diasDeVida} dias.");
        }
    }
}