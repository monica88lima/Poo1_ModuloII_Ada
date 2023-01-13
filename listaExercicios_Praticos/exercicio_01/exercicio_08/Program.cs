namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Carro - 08");

            Carro carro1 = new Carro()
            {
                Cor = "Branco",
                Marca = "Honda",
                CapacidadeDoTanque = 40,
                TipoDeCombustivel = "Flex",
                Modelo = "City"
            };
            carro1.Abastecer(20, "Gasolina");

            Carro carro2 = new Carro();
            carro2.Cor = "Preto";
            carro2.Modelo = "Ranger";
            carro2.Marca = "Ford";
            carro2.CapacidadeDoTanque = 45;
            carro2.TipoDeCombustivel = "Gasolina";


            carro2.Abastecer(45, "Etanol");

            Carro carro3=new Carro();

        }
    }
}