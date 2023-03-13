namespace ListaExercicios06
{
    //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            decimal tempCelsius = Convert.ToDecimal (Console.ReadLine());

            decimal tempFahrenheit = (tempCelsius * 9 / 5) + 32;
            Console.WriteLine($"A sua temperatura em Fahrenheit é de {tempFahrenheit} °F.");
        }
    }
}