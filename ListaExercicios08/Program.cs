namespace ListaExercicios08
{
    //8. Crie um programa para calcular o volume de uma lata de óleo
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoLata;
            do
            {
                Console.Write("Sua lata de olho é cilindrica ou retangular ( 1 = Cilindrica ou 2 = Retangular ): ");
                tipoLata = Console.ReadLine();

                if(tipoLata != "1"  && tipoLata != "2")
                {
                    Console.Clear();
                    Console.WriteLine("!!!O valor inserido deve ser 1 ou 2!!!\n");
                }
            } while (tipoLata != "1" && tipoLata != "2");

            if ( tipoLata == "1" )
            {
                decimal volCilindro;
                decimal PI;
                PI = (decimal)Math.PI;

                Console.Write("Informe o Raio do sua Lata Cilindrica: ");
                double raioCilindro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o Altura do sua lata Cilindrica: ");
                decimal alturaCilindro = Convert.ToDecimal(Console.ReadLine());

                decimal raioAoQuad = Convert.ToDecimal(Math.Sqrt(raioCilindro));

                volCilindro = PI * raioAoQuad * alturaCilindro;

                Console.WriteLine($"O volume de sua lata é de {volCilindro = Math.Round(volCilindro,2)}");
                Console.ReadLine();
            }
            else if (tipoLata == "2")
            {
                Console.Write("Informe a base de sua lata Retangular: ");
                decimal baseLata = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a altura de sua lata Retangular: ");
                decimal alturaLata = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a largura de sua lata Retangular: ");
                decimal larguraLata = Convert.ToDecimal(Console.ReadLine());

                decimal volRetangulo;
                volRetangulo = baseLata * alturaLata * larguraLata;

                Console.WriteLine($"O volume de sua lata Retangular é {volRetangulo = Math.Round(volRetangulo, 2)}.");
                Console.ReadLine();
            }
        }
    }
}
