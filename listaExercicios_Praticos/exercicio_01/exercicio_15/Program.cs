namespace exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Construa uma classe Veiculo que tem como propriedades rodas (1 a n), usaCombustivel (true/false), 
             * uma classe Carro (tipoDecombustivel: 'gasolina', 'álcool', 'flex') que herda de Veiculo e Bicicleta
             * (infantil: true/false - tem que ter mais que 2 rodas) que também herda as características de Veiculo.*/

            Console.WriteLine("Veiculo, bicicleta e carro");

            Bicicleta bikePequena = new Bicicleta(4, false, "Infantil");
            Console.WriteLine($"A bicicleta possui:{bikePequena.Rodas} rodas\n" +
                $"E indicada para o publico infantil:{bikePequena.Infantil}");


            Carro City = new Carro(4, true, "Flex");
            Console.WriteLine($"Este carro usa o combustivel: {City.TipoCombustivel}\n");
                
        }
    }
}