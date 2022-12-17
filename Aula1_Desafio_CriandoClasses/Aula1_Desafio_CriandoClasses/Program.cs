namespace Aula1_Desafio_CriandoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Funcionario funcionario = new Funcionario()
            {

                // cargo_funcionario = (int)Funcionario.Cargo.PM,
                Nome = "Paulo",
                Id = 12,
                Time = "Gestão",
                cargo = Funcionario.Cargo.Dev



            };

            // Console.WriteLine(funcionario.cargo_funcionario);
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Time);
            Console.WriteLine(funcionario.cargo);
        }
    }
}