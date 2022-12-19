namespace exercicio_03_classePessoa_GettersESetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Getters e Setters");

            Pessoa pessoa = new Pessoa()
            {
                PrimeiroNome = "Ana",
                SobrenomePublico = "Souza",
                Email = "AnaS@Gmail.com",
            };

            pessoa.fnNomeCompleto(pessoa.PrimeiroNome, pessoa.SobrenomePublico);           

            Console.WriteLine(pessoa.NomeCompleto +" \n"+ pessoa.Email + "\n" + "Primeiro Nome: " + pessoa.PrimeiroNome );

        }
    }
}