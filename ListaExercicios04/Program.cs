namespace ListaExercicios04
{
    //Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
    //Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumoPKM, kmPercorridos;

            Console.WriteLine("Informe a kilometragem inicial do seu veículo: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a kilometragem final do seu veículo: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos litros de gasolina foram gastos nesse percurso? ");
            double litrosGastos = Convert.ToDouble(Console.ReadLine());

            kmPercorridos = kmFinal - kmInicial;
            consumoPKM = kmPercorridos / litrosGastos;

            Console.WriteLine($"O seu consumo de combustível nessa viagem foi de {consumoPKM} km por litro.");
        }
    }
}