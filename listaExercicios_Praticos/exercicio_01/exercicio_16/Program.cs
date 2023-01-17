namespace exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Construa uma classe Programa com as propriedades duracao e generos (ação, comédia, suspense, drama, terror) e
             * duas classes que herdam desta (Seriado e Filme). A classe Seriado deve ter numeroDeEpisodios (de 1 a n), 
             * anoDeInicio e anoDeFim. Já a classe Filme precisa ter a duracao (em minutos).*/

            Console.WriteLine("Hello, World!");

            Filme filme = new Filme(90,"teste");
            Seriado seriado = new Seriado(40, "ação", 28,2022,2023);
            

            Console.WriteLine($"O Filme tem {filme.Duracao} minutos\n" +
                $"E o Genero é: {filme.Genero}");

            Console.WriteLine($"O Seriado tem {seriado.Duracao} minutos por episodio\n" +
                $"E o Genero é: {seriado.Genero}\n O primeiro episodio foi lança em: {seriado.AnoInicio}\n A serie tem:{seriado.NumeroDeEpisodios} episodios");
        }
    }
}