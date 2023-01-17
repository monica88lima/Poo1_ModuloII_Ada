using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_16
{
    public class Seriado:Programa
    {
        public int NumeroDeEpisodios { get; set; }
        public int AnoInicio { get; set; }
        public int AnoFim { get; set; }
        public Seriado(int minutos, string genero, int numEpisodios, int anoInicio, int anoFim): base(minutos, genero)
        {
            this.Duracao = minutos;
            this.Genero = genero;
            this.NumeroDeEpisodios = numEpisodios;
            this.AnoInicio = anoInicio;
            this.AnoFim = anoFim;
        }
    }
}
