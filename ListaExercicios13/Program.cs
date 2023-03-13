using static System.Reflection.Metadata.BlobBuilder;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace ListaExercicios13
{
//    A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.Cada
//    pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
//    venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
//    Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
//    quantidades de pães e de broas, e depois calcular os dados solicitados.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos pães foram vendidos hoje? ");
            double paes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantas broas foram vendidos hoje? ");
            double broas = Convert.ToDouble(Console.ReadLine());

            double totalVendas = (0.11 * paes) + (1.5 * broas);
            double poupanca = totalVendas * 0.1;

            Console.WriteLine($"Foram vendidos R$ {totalVendas} reais hoje.\nO valor de poupança  diario deve ser de R$ {poupanca}.");
        }
    }
}