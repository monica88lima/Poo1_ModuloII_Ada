namespace Aula1_Desafio_Classes_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Desenvolvedor_Cargo desenvolvedor = new()
            {
                Nome = "Ana",
                Salario = 6000.00,
                Time = "Vendas",
                ID = 123456,
                Idade = 36,
                Nivel = "Pleno"


            };
            Console.WriteLine(desenvolvedor.Nome + " " + desenvolvedor.Salario);

        }
    }
}