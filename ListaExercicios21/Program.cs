namespace ListaExercicios21
{
    //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B.
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            Console.Write("Insira o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if( a == b) 
            {
                resultado = a + b;
                Console.WriteLine($"Resultado soma: {resultado}");
            }
        
            else
            {
                resultado = a * b;
                Console.WriteLine($"Resultado multiplicação: {resultado}");
            }
        }

        
    }
}