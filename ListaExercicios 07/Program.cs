namespace ListaExercicios_07
{
    //Crie um programa para calcular o salário total de um vendedor.Deverá ser informado o salário base e o total de
    //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu salário base: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe a valor em vendas que fez no mês: ");
            decimal vendas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o percentual de comissão sobre suas vendas: : ");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());

            decimal salarioFinal = salarioBase + (vendas * (comissao / 100));

            Console.WriteLine($"Nesse mês você recebeu o salario total de R$: {salarioFinal = Math.Round(salarioFinal, 2)}.");
        }
    }
}