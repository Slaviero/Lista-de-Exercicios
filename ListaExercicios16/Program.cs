namespace ListaExercicios16
{
    //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
    //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            decimal aumento = salario * 1.15m;
            decimal salarioFinal = aumento * 0.92m;

            Console.WriteLine($"Salario Inicial: R${salario = Math.Round(salario, 2)}\nSalario com aumento: R${aumento = Math.Round(aumento, 2)}\nSalario final com descontos: R${salarioFinal = Math.Round(salarioFinal,2)}");
        }
    }
}