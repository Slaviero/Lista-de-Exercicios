namespace ListaExercicios02
{
    //2. Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em Graus Fahrenheit: ");
            double grausF = Convert.ToDouble(Console.ReadLine());
            double celsius;
            //(°F − 32) × 5/9 = °C
            celsius = (grausF - 32) * 5 / 9;
            Console.WriteLine($"A tempratura em graus Celsius é de: {celsius}");
            Console.ReadLine();
        }
    }
}