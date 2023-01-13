namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 02 _CNH");

            CNH cnh1 = new CNH(21, "BR");

            Console.WriteLine($"A idade do Motorista é {cnh1.Idade}\nSua permissão e valida no {cnh1.Pais}");
        }
    }
}