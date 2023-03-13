using System.Runtime.Intrinsics.X86;

namespace ListaExercicios19
{
//    O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
// IMC em adultos Condição
// Abaixo de 18,5
// Abaixo do peso
// Entre 18,5 e 25 Peso normal
// Entre 25 e 30
// Acima do peso
// Acima de 30 obeso
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu peso EXEMPLO (78): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira sua altura EXEMPLO (1,78): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            
            double imc = peso / (altura * altura);
            

            if (imc <= 18.5)
            {
                Console.WriteLine("Você está baixo do peso ideal.");
            }
            else if (imc > 18.5 && imc <25)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }

            else if (imc >= 30)
            {
                Console.WriteLine("Você está em nivel de obesidade.");
            }

            Console.WriteLine("IMC = " + imc);
        }
    }
}