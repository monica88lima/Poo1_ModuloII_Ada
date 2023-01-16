using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    public class Sorteio
    {
        public int NumeroDeInscritos { get; set; } 

        public List<string> NomesInscritos { get; set; } = new List<string>();

        public Sorteio()
        {
             
             
        }
        public  void DeclararVencedor(int numeroSorteado)
        {
            string nomeGanhador = NomesInscritos[numeroSorteado-1];
            Console.WriteLine($"O ganhador(a) foi:{nomeGanhador}, o seu Bilhete Premiado é o de numero: {numeroSorteado}");
        }
        public  int SortearPremio()
        {
            Random rand = new Random();
            

            int numeroPremiado = rand.Next(1,NumeroDeInscritos);
            return numeroPremiado;
        }
    }
}
