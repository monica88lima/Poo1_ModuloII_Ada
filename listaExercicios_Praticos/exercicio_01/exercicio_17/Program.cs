namespace exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma classe Livro com as propriedades autor e ano.
             * Crie também as classes Ebook e AudioBook que herdam de Livro. Ebook deve ter numero 
             * de páginas e número de capítulos. Já a classe AudioBook deve ter a duração total do áudio em minutos.*/

            Console.WriteLine("Livros-Ebook-AudioBook");
            Livro livro = new Livro()
            {
                Ano = 2023,
                Autor = "Margarete Rete"

            };
            Console.WriteLine($"Autor = {livro.Autor}\n Ano Publicação = {livro.Ano}");

            Ebook ebook = new Ebook();
            ebook.NumerosDeCapitulos = 5;
            ebook.NumerosDePaginas = 29;
            ebook.Autor = "Junior Filho";
            ebook.Ano = 2023;
            Console.WriteLine($"Autor = {ebook.Autor}\n Ano Publicação = {ebook.Ano}\n Capitulos = {ebook.NumerosDeCapitulos}\n n° Pg= {ebook.NumerosDePaginas}");

            AudioBook audioBook = new AudioBook()
            {
                Ano = 2022,
                Autor = "Maria Ana",
                Duração = 90,
            };
            Console.WriteLine($"Autor = {audioBook.Autor}\n Ano Publicação = {audioBook.Ano}\n Tempo de Duração= {audioBook.Duração} minutos");
        }
    }
}