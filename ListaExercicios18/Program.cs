    namespace ListaExercicios18
{
    //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor 1 : ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor 2 : ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor 3 : ");
            int val3 = Convert.ToInt32(Console.ReadLine());

            int valorMaior = 0, valorMenor = 0, valorMeio = 0;

            if (val1 > val2 && val1 > val3) 
            {
                valorMaior = val1;
            }
            else if (val3 > val2 && val3 > val1)
            {
                valorMaior = val3;
            }
            else if (val2 > val1 && val2 > val3)
            {
                valorMaior = val2;
            }

            if (val1 < val2 && val1 < val3)
            {
                valorMenor = val1;
            }
            else if (val3 < val2 && val3 < val1)
            {
                valorMenor = val3;
            }
            else if (val2 < val1 && val2 < val3)
            {
                valorMenor = val2;
            }

             if (val1 < valorMaior && val1 > valorMenor)
            {
                valorMeio = val1;
            }
            else if (val3 < valorMaior && val3 > valorMenor)
            {
                valorMeio = val3;
            }
            else if (val2 < valorMaior && val2 > valorMenor)
            {
                valorMeio = val2;
            }
            Console.WriteLine($"Em ordem decrescebte: {valorMaior}, {valorMeio}, {valorMenor}");
        }
    }
}