namespace ListaExercicios12
{
    //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
    //terreno e depois exibir a área do terreno.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a base do terreno: ");
            double baseTerreno = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a altura do terreno: ");
            double alturaTerreno = Convert.ToDouble(Console.ReadLine());

            double area = baseTerreno * alturaTerreno;

            Console.WriteLine($"A area de seu terreno é de {area}.");
        }
    }
}