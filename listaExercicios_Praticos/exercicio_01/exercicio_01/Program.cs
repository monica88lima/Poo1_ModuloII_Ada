namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boletim da Faculdade!!!");

            Boletim boletim = new Boletim("Ana Frozen", 2000,2);
           
            boletim.LstMedias.Add("Português = 9.5");
            boletim.LstMedias.Add("Matemática = 9.0");
            boletim.LstMedias.Add("Geografia = 9.5");
            boletim.LstMedias.Add("História = 9.0");
            boletim.LstMedias.Add("Filosofia = 9.5");
            boletim.LstMedias.Add("Literatura = 8.5");
           
            Console.WriteLine($"Nome Aluno = {boletim.NomeAluno} - Semestre {boletim.Semestre} - Ano {boletim.Ano}" );
           
            
            foreach(string medias in boletim.LstMedias)
            {
                Console.WriteLine($"Notas {medias}");
            }
        }
    }
}