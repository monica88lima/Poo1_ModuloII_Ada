using System.Runtime.Intrinsics.X86;

namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma classe Time que tenha como propriedade o nome do país, nome do esporte e a pontuação dele 
             em um torneio.Sua pontuação pode ser acrescida por um método pontua que recebe como parâmetro "W" para
             vitória(+3 pontos), "L" para derrota(+0 pontos) e "D" para empate(+1 ponto).*/

            Console.WriteLine("Exercicio_09\n");

            Time time1 = new Time("Brasil", "São Paulo", 10);
           
            Console.WriteLine($"Time:{time1.NomeTime}\n Pontos Inciais:{time1.PontuacaoTime}");
            time1.Pontuar("W");
            time1.Pontuar("D");
            time1.Pontuar("L");
            time1.Pontuar("D");
            time1.Pontuar("L");
            time1.Pontuar("W");
            Console.WriteLine($"Time:{time1.NomeTime}\n Pontos Final:{time1.PontuacaoTime}");
        }
    }
}